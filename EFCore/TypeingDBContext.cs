using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeingTest.EFCore.Model;

namespace TypeingTest.EFCore
{
    public class TypeingDBContext : DbContext
    {
       // public DbSet<Product> Products { get; set; }
        public DbSet<RoleOld> Roles { get; set; }
        //public DbSet<UserDetail> UserDetail { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(Program.Config.GetConnectionString("database"));
        //    => optionsBuilder.UseSqlite("Data Source=products.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoleOld>().HasData(
                new RoleOld { RoleId = 1, Name = "Administrator" },
                new RoleOld { RoleId = 2, Name = "Student" },
                new RoleOld { RoleId = 3, Name = "Other" });

            //modelBuilder.Entity<UserDetail>().HasData(
            //   new UserDetail { Id = 1, Name = "Cheese", Email="adhikary.tapash@gmail.com", Password = "" });

            //modelBuilder.Entity<Product>().HasData(
            //    new Product { ProductId = 1, RoleId = 1, Name = "Cheddar" },
            //    new Product { ProductId = 2, RoleId = 1, Name = "Brie" },
            //    new Product { ProductId = 3, RoleId = 1, Name = "Stilton" },
            //    new Product { ProductId = 4, RoleId = 1, Name = "Cheshire" },
            //    new Product { ProductId = 5, RoleId = 1, Name = "Swiss" },
            //    new Product { ProductId = 6, RoleId = 1, Name = "Gruyere" },
            //    new Product { ProductId = 7, RoleId = 1, Name = "Colby" },
            //    new Product { ProductId = 8, RoleId = 1, Name = "Mozzela" },
            //    new Product { ProductId = 9, RoleId = 1, Name = "Ricotta" },
            //    new Product { ProductId = 10, RoleId = 1, Name = "Parmesan" },
            //    new Product { ProductId = 11, RoleId = 2, Name = "Ham" },
            //    new Product { ProductId = 12, RoleId = 2, Name = "Beef" },
            //    new Product { ProductId = 13, RoleId = 2, Name = "Chicken" },
            //    new Product { ProductId = 14, RoleId = 2, Name = "Turkey" },
            //    new Product { ProductId = 15, RoleId = 2, Name = "Prosciutto" },
            //    new Product { ProductId = 16, RoleId = 2, Name = "Bacon" },
            //    new Product { ProductId = 17, RoleId = 2, Name = "Mutton" },
            //    new Product { ProductId = 18, RoleId = 2, Name = "Pastrami" },
            //    new Product { ProductId = 19, RoleId = 2, Name = "Hazlet" },
            //    new Product { ProductId = 20, RoleId = 2, Name = "Salami" },
            //    new Product { ProductId = 21, RoleId = 3, Name = "Salmon" },
            //    new Product { ProductId = 22, RoleId = 3, Name = "Tuna" },
            //    new Product { ProductId = 23, RoleId = 3, Name = "Mackerel" },
            //    new Product { ProductId = 24, RoleId = 4, Name = "Rye" },
            //    new Product { ProductId = 25, RoleId = 4, Name = "Wheat" },
            //    new Product { ProductId = 26, RoleId = 4, Name = "Brioche" },
            //    new Product { ProductId = 27, RoleId = 4, Name = "Naan" },
            //    new Product { ProductId = 28, RoleId = 4, Name = "Focaccia" },
            //    new Product { ProductId = 29, RoleId = 4, Name = "Malted" },
            //    new Product { ProductId = 30, RoleId = 4, Name = "Sourdough" },
            //    new Product { ProductId = 31, RoleId = 4, Name = "Corn" },
            //    new Product { ProductId = 32, RoleId = 4, Name = "White" },
            //    new Product { ProductId = 33, RoleId = 4, Name = "Soda" });
        }
    }
}
