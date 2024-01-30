using FutebolPrimeGestor.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FutebolPrimeGestor.Infra.Data.Context
{
    public class FutebolPrimeGestorDbContext : DbContext
    {
        public FutebolPrimeGestorDbContext(DbContextOptions options) : base(options) { }

        DbSet<Cliente> Clientes { get; set; }
        DbSet<Quadra> Quadras { get; set; }
        DbSet<AluguelDeQuadra> AlugueisDeQuadras { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(FutebolPrimeGestorDbContext).Assembly);
        }
    }
}
