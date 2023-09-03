using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _07_H_Airlines;

namespace _07_H_Airlaines_.Data.Configurations
{
    internal class AccountConfigs : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.HasKey(x => x.Id).HasName("Accounts");
            builder.Property(x => x.Login).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Password).HasMaxLength(200).IsRequired();
            builder.HasOne(x => x.Client).WithOne(x => x.Account);
        }
    }
}
