using HotelDb.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelDb.Data.Configurations
{
    internal class EmployeeConfigs : IEntityTypeConfiguration<Employee>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(200).IsRequired();
            builder.Property(x => x.Surname).HasMaxLength(200).IsRequired();
            builder.Property(x => x.PhoneNumber).HasMaxLength(16).IsRequired();
            builder.Property(x => x.Gmail).HasMaxLength(100).IsRequired();
            builder.Property(x => x.Salary).IsRequired();

            builder.HasOne(x => x.Hotel).WithMany(x => x.Employees).HasForeignKey(x => x.HotelId);
            builder.HasOne(x => x.Position).WithMany(x => x.Employees).HasForeignKey(x => x.PositionId);

        }
    }
}
