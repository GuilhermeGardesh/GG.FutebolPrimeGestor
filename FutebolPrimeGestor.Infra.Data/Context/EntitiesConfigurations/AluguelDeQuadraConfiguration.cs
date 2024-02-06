using FutebolPrimeGestor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FutebolPrimeGestor.Infra.Data.Context.EntitiesConfigurations
{
    public class AluguelDeQuadraConfiguration : IEntityTypeConfiguration<AluguelDeQuadra>
    {
        public void Configure(EntityTypeBuilder<AluguelDeQuadra> builder)
        {
            builder.ToTable("AlugueisDeQuadras");
            builder.HasKey(x => x.Id);
        }
    }
}
