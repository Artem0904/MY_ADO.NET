using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_C_dataAnotations_Shop.Data.Configurations
{
    internal class WorkerConfigs : IEntityTypeConfiguration<Worker>
    { 
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasKey(x => x.Id).HasName("Workers");
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Salary).IsRequired();
            builder.Property(x => x.Gmail).HasMaxLength(100).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(16).IsRequired();

        }
    }
}
