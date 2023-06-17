using Fedra.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Fedra.Data.Context
{
    public partial class FedraDbContext : DbContext
    {
        public FedraDbContext()
        {
        }

        public FedraDbContext(DbContextOptions<FedraDbContext> options)
         : base(options)
        {

        }

        public DbSet<Tercero> Terceros { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Exencion> Exenciones { get; set; }
        public DbSet<Impuesto> Impuestos { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<TipoIdentificacion> TiposIdentificacion { get; set; }
        public DbSet<Producto> Productos { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);
        }

        private void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {  

        }
    }
}
