using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDb.Data.Configurations
{
    internal class HotelConfigs : IEntityTypeConfiguration<Entities.Hotel>
    {

        public void Configure(EntityTypeBuilder<Entities.Hotel> builder)
        {
            builder.HasKey(x => x.Id).HasName("Hotels");
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
