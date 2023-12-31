﻿using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelDb.Data.Configurations
{
    internal class VisitorsConfigs : IEntityTypeConfiguration<Visitor>
    {

        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Visitor> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(200).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(200).IsRequired();
        }
    }
}
