using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Task8_dotNET.Models;

namespace Task8_dotNET.Data
{
    public class GifContext : DbContext
    {
        public GifContext(DbContextOptions<GifContext> options)
            : base(options)
        {
        }

        public DbSet<Gif> Gifs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gif>().ToTable("Gif");
            modelBuilder.Entity<User>().ToTable("User");
        }
    }
}
