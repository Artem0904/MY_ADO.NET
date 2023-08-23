using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _08_C_dataAnotations_Shop.Data.Configurations
{
    internal class ProductConfigs : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id).HasName("Products");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Discount).IsRequired();
            builder.Property(x => x.Quantity).IsRequired();
            builder.Property(x => x.IsInStock).IsRequired();

            builder.HasOne(x => x.Category).WithMany(x => x.Products);
            builder.HasMany(x => x.Shops).WithMany(x => x.Products);
        }
    }
}

