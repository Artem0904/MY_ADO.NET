using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelDb.Data.Configurations
{
    internal class PositionConfigs : IEntityTypeConfiguration<Position>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Position> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        }
    }
}
