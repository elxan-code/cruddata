using Microsoft.EntityFrameworkCore;
using sixteen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sixteen.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Costumors> Costumorses { get; set; }
        public DbSet<Headtitle> Headtitles { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Options> Optionss { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Settings> Settinges { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Specality> Specalities { get; set; }
        public DbSet<Teams> Teamses { get; set; }
        public object Teams { get; internal set; }
    }
}
