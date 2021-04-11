using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SMF
{
    public class TClientesBL
    {
        Contexto _contexto;

        public BindingList<TCliente> ListaTClientes { get; set; }

        public TClientesBL()
        {
            _contexto = new Contexto();
            ListaTClientes = new BindingList<TCliente>();
        }

        public BindingList<TCliente> ObtenerTClientes()
        {
            _contexto.TClientes.Load();
            ListaTClientes = _contexto.TClientes.Local.ToBindingList();

            return ListaTClientes;
        }
    }

    public class TCliente
    {
        public int Id { get; set; }
        public string Condicion { get; set; }
    }
}

