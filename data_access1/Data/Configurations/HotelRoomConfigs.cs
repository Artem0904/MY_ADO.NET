using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDb.Data.Configurations
{
    internal class HotelRoomConfigs : IEntityTypeConfiguration<HotelRoom>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<HotelRoom> builder)
        {
            builder.HasKey(x => x.Id).HasName("HotelRooms");
            builder.Property(x => x.Number).IsRequired();
            builder.Property(x => x.IsVip).IsRequired();
            builder.Property(x => x.CountVisitors).IsRequired();
            builder.Property(x => x.PriceForDay).IsRequired();

            builder.HasMany(x => x.Visitors).WithOne(x => x.HotelRoom).HasForeignKey(x => x.HotelRoomId);    


        }
    }
}
