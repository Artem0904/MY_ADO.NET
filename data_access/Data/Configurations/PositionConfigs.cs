using Hotel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Data.Configurations
{
    internal class PositionConfigs : IEntityTypeConfiguration<Position>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(x => x.Id).HasName("Positions");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        }
    }
}
