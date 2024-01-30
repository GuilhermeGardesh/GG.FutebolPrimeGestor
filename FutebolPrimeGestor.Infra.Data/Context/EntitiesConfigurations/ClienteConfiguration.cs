using FutebolPrimeGestor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutebolPrimeGestor.Infra.Data.Context.EntitiesConfigurations
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CPF).HasColumnType("CHAR(11)").IsRequired();
            builder.Property(x => x.Contato).HasColumnType("CHAR(11)").IsRequired();
            builder.Property(x => x.Nome).HasColumnType("VARCHAR(200)").IsRequired();
            builder.HasIndex(x => x.CPF).HasDatabaseName("idx_cliente_cpf");

            builder
                .HasMany(x => x.AlugueisDeQuadras)
                .WithOne(x => x.Cliente)
                .HasForeignKey(x => x.IdCliente)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
