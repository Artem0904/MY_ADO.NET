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
    internal class CityConfigs : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id).HasName("Cities");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.Country).WithMany(x => x.Cities).HasForeignKey(x => x.CountryId);
            builder.HasMany(x => x.Flights).WithOne(x => x.ArivalCity).HasForeignKey(x => x.CityArivalId);
            builder.HasMany(x => x.Flights).WithOne(x => x.DepartureCity).HasForeignKey(x => x.CityArivalId);
        }
    }
}
