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
    internal class ClienrConfigd : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(x => x.Id).HasName("Clients");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Gmail).HasMaxLength(200).IsRequired();
            builder.Property(x => x.IsMale);
            builder.HasMany(x => x.Flights).WithMany(x => x.Clients);
        }
    }
}
