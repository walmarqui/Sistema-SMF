using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Runtime.Remoting.Contexts;

namespace BL.SMF
{
    public class Contexto: DbContext
    {
       
        public Contexto():base("Productos")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());
        }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Tipo> Tipos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<TCliente> TClientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet Factura { get; set; }
    }
}
