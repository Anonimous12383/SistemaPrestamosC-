using System.Data.Entity;
using Prestamos.Domain;

namespace Prestamos.Infrastructure
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("PrestamosDbConnection")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }
        public DbSet<Pago> Pagos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .HasMany(c => c.Prestamos)
                .WithRequired(p => p.Cliente)
                .HasForeignKey(p => p.ClienteId);

            modelBuilder.Entity<Prestamo>()
                .HasMany(p => p.Pagos)
                .WithRequired(pg => pg.Prestamo)
                .HasForeignKey(pg => pg.PrestamoId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
