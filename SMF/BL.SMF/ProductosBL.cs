using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SMF
{
    public class ProductosBL
    {
        BindingList<Producto> ListaProductos;
        public ProductosBL()
        {
            ListaProductos = new BindingList<Producto>();

            var producto1 = new Producto();
            producto1.Id = 1;
            producto1.Codigo = 001;
            producto1.Descripcion = "Tenis Nike";
            producto1.Precio = 2500;
            producto1.Existencia = 10;
            producto1.Activo = true;

            ListaProductos.Add(producto1);
        }

        public BindingList<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }

        public  class Producto
        {
            public int Id { get; set; }
            public int Codigo { get; set; }
            public string Descripcion { get; set; }
            public string Categoria { get; set; }
            public double Precio { get; set; }
            public int Existencia { get; set; }
            public bool Activo { get; set; }
        }
    }
}
