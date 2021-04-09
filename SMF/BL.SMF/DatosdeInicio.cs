using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.SMF
{
    class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            /* var usuarioAdmin = new Usuario();
             usuarioAdmin.Nombre = "admin";
             usuarioAdmin.Contrasena = "123";

             contexto.Usuarios.Add(usuarioAdmin);*/

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Deportes";
            contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Casual";
            contexto.Categorias.Add(categoria2);

            var tipo1 = new Tipo();
            tipo1.Descripcion = "Zapatos";
            contexto.Tipos.Add(tipo1);

            var tipo2 = new Tipo();
            tipo2.Descripcion = "Ropa";
            contexto.Tipos.Add(tipo2);

            base.Seed(contexto); 
        }
    }
}
