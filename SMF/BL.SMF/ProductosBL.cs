using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SMF
{
    public class ProductosBL
    {
        Contexto _contexto;
        public BindingList<Producto> ListaProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaProductos = new BindingList<Producto>();
        }

        public IEnumerable<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();

            return ListaProductos.OrderBy(producto => producto.Descripcion);
        }

        public IEnumerable<Producto> ObtenerProductos(string buscar)
        { 
            var descripcion = buscar.ToLower().Trim();

            var resultado = _contexto.Productos.Where(r => r.Descripcion.ToLower().Contains(descripcion)).ToList();

            return resultado;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }
        public Resultado GuardarProducto(Producto producto)
        {
            var resultado = Validar(producto);
            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarProducto()
        {
            var nuevoProducto = new Producto();

            ListaProductos.Add(nuevoProducto);
        }
         public bool EliminarProducto(int id)
        {
            foreach (var producto in ListaProductos)
            {
                if(producto.Id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }

            }

            return false;
        }

        private Resultado Validar(Producto producto)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;


            if (producto == null)
            {
                resultado.Mensaje = "Agregue un producto valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }


            if (producto.Existencia < 0 )
            {
                resultado.Mensaje = "La existencia debe ser mayor que cero";
                resultado.Exitoso = false;
            }


            if (producto.Precio < 0)
            {
                resultado.Mensaje = "El precio debe ser mayor que cero";
                resultado.Exitoso = false;
            }

            if (producto.CategoriaId == 0)
            {
                resultado.Mensaje = "Seleccione una Categoria";
                resultado.Exitoso = false;
            }

            if (producto.TipoId == 0)
            {
                resultado.Mensaje = "Seleccione un Tipo";
                resultado.Exitoso = false;
            }

            return resultado;
       
        }

        public class Productos
        {
        }
    }

         public  class Producto
         {
            public int Id { get; set; }
            public string Codigo { get; set; }
            public string Descripcion { get; set; }
            public int CategoriaId { get; set; }
            public Categoria Categoria { get; set; }
            public int TipoId { get; set; }
            public Tipo Tipo { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public byte[] Foto { get; set; }
            public bool Activo { get; set; }

            public Producto()
            {
                Activo = true;
            }
        }
    
        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }

        }

}
