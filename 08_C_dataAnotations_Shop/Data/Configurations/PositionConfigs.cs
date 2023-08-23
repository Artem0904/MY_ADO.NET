using _08_C_dataAnotations_Shop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_C_dataAnotations_Shop.Data.Configurations
{
    internal class PositionConfigs : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(x => x.Id).HasName("Posotions");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.HasMany(x => x.Workers).WithOne(x => x.Position).HasForeignKey(x => x.PositionId);
        }
    }
}
