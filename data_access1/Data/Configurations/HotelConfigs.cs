using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelDb.Data.Configurations
{
    internal class HotelConfigs : IEntityTypeConfiguration<Entities.Hotel>
    {
        public void Configure(EntityTypeBuilder<Entities.Hotel> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Adress).HasMaxLength(200).IsRequired();
            builder.Property(x => x.ContactNumber).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Stars).IsRequired();
            builder.Property(x => x.CountHotelRooms).IsRequired();
            
            builder.HasMany(x => x.HotelRooms).WithOne(x => x.Hotel).HasForeignKey(x => x.HotelId);
        }
    }
}
