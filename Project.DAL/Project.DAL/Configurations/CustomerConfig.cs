using Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DAL.Configurations
{
    public class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.Property(e => e.first_name)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(e => e.last_name)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(e => e.age)
                   .HasMaxLength(50)
                   .IsRequired();
            builder.Property(e => e.RefreshToken)
                        .HasMaxLength(256)
                        .IsRequired();

            builder.Property(e => e.RefreshTokenExpiryTime)
                   .IsRequired();



        }
    }
}
