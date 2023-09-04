using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelDb.Data.Configurations
{
    internal class CountryConfigs : IEntityTypeConfiguration<Country>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();


        }
    }
}
