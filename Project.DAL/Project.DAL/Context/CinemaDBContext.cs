using Project.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.DAL.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Project.DAL.Context
{
    public class CinemaDBContext : IdentityDbContext<Customer>
    {

        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<CinemaPlan> CinemaPlans { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieGenre> MovieGenres { get; set; }
        public DbSet<Place> Places { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Seance> Seances { get; set; }


        public CinemaDBContext(DbContextOptions<CinemaDBContext> options)
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new MovieConfig());
            modelBuilder.ApplyConfiguration(new CinemaConfig());
            modelBuilder.ApplyConfiguration(new PlaceConfig());
            modelBuilder.ApplyConfiguration(new GenreConfig());
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            modelBuilder.ApplyConfiguration(new SeanceConfig());
            modelBuilder.ApplyConfiguration(new CinemaPlanConfig());
            modelBuilder.ApplyConfiguration(new ReservationConfig());
            modelBuilder.ApplyConfiguration(new MovieGenreConfig());
            base.OnModelCreating(modelBuilder);
        }
    }
}
