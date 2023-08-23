using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_C_dataAnotations_Shop.Data.Configurations
{
    internal class ShopConfigs : IEntityTypeConfiguration<Shop>
    {
        public void Configure(EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(x => x.Id).HasName("Shops");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Adress).HasMaxLength(200).IsRequired();
            builder.Property(x => x.ParkingArea).IsRequired(false);
            builder.HasOne(x => x.City).WithMany(x => x.Shops);

            builder.HasMany(x => x.Workers).WithOne(x => x.Shop);

        }
    }
}
