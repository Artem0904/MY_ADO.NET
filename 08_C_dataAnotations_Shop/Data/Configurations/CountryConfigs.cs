using _08_C_dataAnotations_Shop.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_C_dataAnotations_Shop.Data.Configurations
{
    internal class CountryConfigs : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id).HasName("Countries");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.HasMany(x => x.Cites).WithOne(x => x.Country).HasForeignKey(x => x.Id);

        }
    }
}
