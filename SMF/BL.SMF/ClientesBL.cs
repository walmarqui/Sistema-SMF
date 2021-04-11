using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SMF
{
    public class ClientesBL
    {
        Contexto _contexto;
        public BindingList<Cliente> ListaClientes { get; set; }

        public ClientesBL()
        {
            _contexto = new Contexto();
            ListaClientes = new BindingList<Cliente>();
        }

        public BindingList<Cliente> ObtenerClientes()
        {
            _contexto.Clientes.Load();
            ListaClientes = _contexto.Clientes.Local.ToBindingList();

            return ListaClientes;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarCliente(Cliente cliente)
        {
            var resultado = Validar(cliente);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCliente()
        {
            var nuevoCliente = new Cliente();

            ListaClientes.Add(nuevoCliente);
        }
        public bool EliminarCliente(int id)
        {
            foreach (var cliente in ListaClientes)
            {
                if (cliente.Id == id)
                {
                    ListaClientes.Remove(cliente);
                    _contexto.SaveChanges();
                    return true;
                }

            }

            return false;
        }

        private Resultado Validar(Cliente cliente)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(cliente.NombreCompleto) == true)
            {
                resultado.Mensaje = "Ingrese un nombre de cliente";
                resultado.Exitoso = false;
            }


            if (string.IsNullOrEmpty(cliente.Direccion) == true)
            {
                resultado.Mensaje = "Asigne una direccion";
                resultado.Exitoso = false;
            }


            if (string.IsNullOrEmpty(cliente.Telefono) == true)
            {
                resultado.Mensaje = "Ingrese un numero telefonico";
                resultado.Exitoso = false;
            }

            if (cliente.Identidad == "")
            {
                resultado.Mensaje = "Ingrese un numero de ID valido";
                resultado.Exitoso = false;
            }

            if (cliente.Rtn == "")
            {
                resultado.Mensaje = "ingrese el rtn";
                resultado.Exitoso = false;
            }

            return resultado;

        }

    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public int TClienteId { get; set; }
        public TCliente TCliente { get; set; }
        public string Identidad { get; set; }
        public string NombreCompleto { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string Rtn { get; set; }
        public byte[] Foto { get; set; }
        public bool Activo { get; set; }
    }

}
