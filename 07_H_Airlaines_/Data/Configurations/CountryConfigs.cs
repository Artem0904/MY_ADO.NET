using _07_H_Airlines;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_H_Airlaines_.Data.Configurations
{
    internal class CountryConfigs : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.HasKey(x => x.Id).HasName("Countries");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
        }
    }
}
