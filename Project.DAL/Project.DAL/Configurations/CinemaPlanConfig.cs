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
    public class CinemaPlanConfig : IEntityTypeConfiguration<CinemaPlan>
    {
        public void Configure(EntityTypeBuilder<CinemaPlan> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Cinema)
                .WithMany(d => d.CinemaPlans)
                .HasForeignKey(e => e.cinema_id);

            builder.Property(e => e.row_number)
                 .IsRequired();

            builder.Property(e => e.place_number)
                 .IsRequired();


        }
    }
}
