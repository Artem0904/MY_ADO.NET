using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDb.Data.Configurations
{
    internal class CountryConfigs : IEntityTypeConfiguration<Country>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id).HasName("Countries");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            builder.HasMany(X => X.Cities).WithOne(x => x.Country).HasForeignKey(x => x.CountryId);

        }
    }
}
