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
    public class AluguelDeQuadraConfiguration : IEntityTypeConfiguration<AluguelDeQuadra>
    {
        public void Configure(EntityTypeBuilder<AluguelDeQuadra> builder)
        {
            builder.ToTable("AlugueisDeQuadras");
            builder.HasKey(x => x.Id);
        }
    }
}
