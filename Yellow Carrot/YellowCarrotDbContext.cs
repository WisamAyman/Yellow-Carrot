using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yellow_Carrot.Models;

namespace Yellow_Carrot
{
    public class YellowCarrotDbContext : DbContext  
    {
        public YellowCarrotDbContext()
        {

        }

        public YellowCarrotDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public virtual DbSet<Ingredient> Ingredients { get; set; }
        public virtual DbSet<Recipe> Recipes { get; set; }
        public virtual DbSet<Tag> Tags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=localhost\SQLEXPRESS;Database=YellowCarrotDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
