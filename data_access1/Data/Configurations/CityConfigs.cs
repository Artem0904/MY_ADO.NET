﻿using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelDb.Data.Configurations
{
    internal class CityConfigs : IEntityTypeConfiguration<City>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            builder.HasMany(x => x.Hotels).WithOne(x => x.City).HasForeignKey(x => x.CityId);
            builder.HasOne(x => x.Country).WithMany(x => x.Cities).HasForeignKey(x => x.CountryId);
        }
    }
}
