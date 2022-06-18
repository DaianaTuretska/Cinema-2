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
    public class ReservationConfig : IEntityTypeConfiguration<Reservation>
    {
        public void Configure(EntityTypeBuilder<Reservation> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Customer)
           .WithMany(d => d.Reservations)
           .HasForeignKey(e => e.customer_id);

            builder.HasOne(e => e.Seance)
               .WithMany(d => d.Reservations)
               .HasForeignKey(k => k.seance_id);


            builder.HasOne(e => e.Place)
               .WithMany(d => d.Reservations)
               .HasForeignKey(k => k.place_id);
        }
    }
}
