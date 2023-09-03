using _07_H_Airlines;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_H_Airlaines_.Data.Configurations
{
    internal class AirplainesConfigs : IEntityTypeConfiguration<Airplane>
    {
        public void Configure(EntityTypeBuilder<Airplane> builder)
        {
            builder.HasKey(x => x.Id).HasName("Airplanes");
            builder.Property(x => x.Model).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Type).HasMaxLength(200).IsRequired();
            builder.Property(x => x.MaxCountPass).IsRequired();
            builder.HasOne(x => x.Country).WithMany(x => x.Airplanes).HasForeignKey(x => x.CountryId);
            builder.HasMany(x => x.Flights).WithOne(x => x.Airplane).HasForeignKey(x => x.AirplaneId);
        }
    }
}
