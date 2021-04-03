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
            //ya no se utiliza datos de prueba borrar

           /* var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Codigo = "001";
            producto1.Descripcion = "Tenis Nike";
            producto1.Categoria = "Deportivo";
            producto1.Precio = 2500;
            producto1.Existencia = 10;
            producto1.Activo = true;

            ListaProductos.Add(producto1);*/
        }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
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

            if(string.IsNullOrEmpty(producto.Descripcion) == true)
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
            public string Categoria { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public byte[] Foto { get; set; }
            public bool Activo { get; set; }
        }
    
        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }

        }

}
