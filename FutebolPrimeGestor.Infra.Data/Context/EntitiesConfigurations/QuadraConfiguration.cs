using FutebolPrimeGestor.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutebolPrimeGestor.Infra.Data.Context.EntitiesConfigurations
{
    public class QuadraConfiguration : IEntityTypeConfiguration<Quadra>
    {
        public void Configure(EntityTypeBuilder<Quadra> builder)
        {
            builder.ToTable("Quadras");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Numero).IsRequired();
            builder.Property(x => x.HorarioInicioFuncionamento).IsRequired();
            builder.Property(x => x.HorarioFimFuncionamento).IsRequired();
            builder.Property(x => x.Valor).IsRequired();

            builder
                .HasMany(x => x.AlugueisDeQuadras)
                .WithOne(x => x.Quadra)
                .HasForeignKey(x => x.IdQuadra)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
