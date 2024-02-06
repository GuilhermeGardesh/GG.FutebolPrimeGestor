using FutebolPrimeGestor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FutebolPrimeGestor.Infra.Data.Context
{
    public class FutebolPrimeGestorDbContext : DbContext
    {
        public FutebolPrimeGestorDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Quadra> Quadras { get; set; }
        public DbSet<AluguelDeQuadra> AlugueisDeQuadras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FutebolPrimeGestorDbContext).Assembly);
        }
    }
}
