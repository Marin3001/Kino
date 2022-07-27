using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CinemaSystemApp;

namespace CSData
{
    public class DataContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Place> Place { get; set; }
        public DbSet<Film> Film { get; set; }
        public DbSet<Ticket> Ticket { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder
        //    optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocal;Database" + 
        //        "=CinemaSystemApp; Integrated Security = True; Trusted_Connection =" +
        //        "true; MultipleActiveResultSets = True");
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder
            optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database = CSData; Integrated Security = True; Trusted_Connection =true; MultipleActiveResultSets = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var film = modelBuilder.Entity<Film>();
            var ticket = modelBuilder.Entity<Ticket>();
            var user = modelBuilder.Entity<User>();
            var place = modelBuilder.Entity<Place>();

            film.ToTable("Films");
            ticket.ToTable("Tickets");
            user.ToTable("Users");
            place.ToTable("Cinemas");

            modelBuilder.Entity<Place>(
                b =>
                {
                    b.HasKey("ID");
                    b.Property(e => (e.Row));
                    b.Property(e => (e.Number));
                    b.Property(e => (e.address));
                    b.Property(e => (e.cinemanumber));
                    b.Property(e => (e.capacity));
                });
            modelBuilder.Entity<User>(
                b =>
                {
                    b.HasKey("ID");
                    b.Property(e => (e.Discount));
                    b.Property(e => (e.UserType));
                    b.Property(e => (e.Name));
                });
            modelBuilder.Entity<Film>(
                b =>
                {
                    b.HasKey("ID");
                    b.Property(e => (e.Duration));
                    b.Property(e => (e.Genre));
                    b.Property(e => (e.FilmName));
                    b.Property(e => (e.ProjectionType));
                });
            modelBuilder.Entity<Ticket>(
                b =>
                {
                    b.HasKey("ID");
                    //b.Property(e => (e.ID));
                    b.Property(e => (e.Price));
                    //b.Property(e => (e.User));
                    //b.Property(e => (e.Place));

                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
