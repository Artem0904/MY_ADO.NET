using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_H_Airlines;

namespace _07_H_Airlaines_.Data.Configurations
{
    internal class FlightConfigs : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {
            builder.HasKey(x => x.Id).HasName("Flights");
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.ArivalDate).IsRequired();
            builder.Property(x => x.DepartureDate).IsRequired();

        }
    }
}
