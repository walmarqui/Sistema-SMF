using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SMF
{
    public class FacturaBL
    {
        Contexto _contexto;
        public BindingList<Factura> ListaFactura { get; set; }

        public FacturaBL()
        {
            _contexto = new Contexto();

        }

        public BindingList<Factura> ObtenerFactura()
        {
            _contexto.Factura.Include("FacturaDetalle");
            ListaFactura = _contexto.Factura.Local.ToBindingList();

            return ListaFactura;
        }

        public void AgregarFactura()
        {
            var nuevaFactura = new Factura();

            ListaFactura.Add(nuevaFactura);
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCliente(Factura Factura)
        {
            var resultado = Validar(Factura);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        private Resultado Validar(Factura factura)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            return resultado;
        }
    }

    public class Factura
    {
        public int id { get; set; }
        public DateTime Fecha { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public BindingList<FacturaDetalle> FacturaDetalle { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Factura()
        {
            Fecha = DateTime.Now;
            FacturaDetalle = new BindingList<FacturaDetalle>();
            Activo = true;
        }

    }

    public class FacturaDetalle
    {
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
        public double Total { get; set; }

        public FacturaDetalle()
        {
            Cantidad = 1;
        }
    }
}
