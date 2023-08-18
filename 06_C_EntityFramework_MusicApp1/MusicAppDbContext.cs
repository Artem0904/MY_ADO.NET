using Microsoft.EntityFrameworkCore;
using System;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;

namespace _06_C_EntityFramework_MusicApp
{
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; }

    }

    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
        public ICollection<Album> Albums { get; set; }

    }
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Album> Albums { get; set; }

    }
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Year { get; set; }
        public int? Rating { get; set; }
        public int ArtistId { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; } 
        public ICollection<Song> Songs { get; set; }
    }
    public class Song
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int? Rating { get; set; }
        public int AlbumId { get; set; }
        public int Listens { get; set; }
        public Album Album { get; set; }
        public ICollection<PlayList> PlayLists { get; set; }
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<PlayList> PlayLists { get; set; }

    }

    public class PlayList
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Song> Songs { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }


    internal class MusicAppDbContext : DbContext
    {
        public MusicAppDbContext() : base()
        {
            //this.Database.EnsureDeleted();
            //// create database if does not exists
            //this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string conn = "Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = MusicApp; Integrated Security = True; Connect Timeout = 30; Encrypt = False; Trust Server Certificate = False; Application Intent = ReadWrite; Multi Subnet Failover = False";
            optionsBuilder.UseSqlServer(conn);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Genres
            modelBuilder.Entity<Genre>().HasData(
            new Genre { Id = 1, Name = "Rock" },
                new Genre { Id = 2, Name = "Pop" },
                new Genre { Id = 3, Name = "Hip Hop" },
                new Genre { Id = 4, Name = "Electronic" },
                new Genre { Id = 5, Name = "Jazz" }
            );

            // Categories
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Favorites" },
                new Category { Id = 2, Name = "Party" },
                new Category { Id = 3, Name = "Chill" },
                new Category { Id = 4, Name = "Workout" },
                new Category { Id = 5, Name = "Focus" }
            );
        }


        // Object Collections (Tables in SQL)
        public DbSet<Country> Countries { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }

        
    }
}
