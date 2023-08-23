using _08_C_dataAnotations_Shop.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_C_dataAnotations_Shop.Data.Configurations
{
    internal class CityConfigs : IEntityTypeConfiguration<City>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id).HasName("Cities");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();

            builder.HasMany(x => x.Shops).WithOne(x => x.City).HasForeignKey(x => x.CityId);
        }
    }
}
