using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using Microsoft.Extensions.Configuration;
//using System.Configuration;

namespace DAL
{
    public class InventoryDbContext :DbContext
    {
        //public InventoryDbContext(DbContextOptions<InventoryDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Build configuration
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            // Get connection string
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Connection string not found in appsettings.json.");
            }

            optionsBuilder.UseLazyLoadingProxies().UseSqlServer(connectionString);
            
        }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<Stock> Stocks { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }

        public virtual DbSet<SalesDetails> SalesDetails { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
               new Category { Id = 1, Name = "Asus Laptops" },
                new Category { Id = 2, Name = "Dell Laptops" },
                new Category { Id = 3, Name = "HP Laptops" },
                new Category { Id = 4, Name = "Apple Laptops" },
                new Category { Id = 5, Name = "Lenovo Laptops" }
            );


            // Seed data for Supplier - Adding suppliers for laptops
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, Name = "Dell Technologies", Address = "One Dell Way, Round Rock, TX 78682, USA", Contact = "+1 800-456-3355" },
                new Supplier { Id = 2, Name = "HP Inc.", Address = "1501 Page Mill Road, Palo Alto, CA 94304, USA", Contact = "+1 800-474-6836" },
                new Supplier { Id = 3, Name = "Apple Inc.", Address = "1 Infinite Loop, Cupertino, CA 95014, USA", Contact = "+1 800-275-2273" },
                new Supplier { Id = 4, Name = "Lenovo Group Limited", Address = "6/F, Lenovo Building, 29 Science Park Road, Hong Kong", Contact = "+852 2833 2111" },
                new Supplier { Id = 5, Name = "Ingram Micro", Address = "3351 Michelson Drive, Suite 100, Irvine, CA 92612, USA", Contact = "+1 800-456-8000" }
            );
            modelBuilder.Entity<Product>().HasData(
                 new Product { ProductId = 1, Name = "Dell XPS 13", Price = 1200.00m, CategoryId = 2, SupplierId = 1 },
                 new Product { ProductId = 2, Name = "HP Spectre x360", Price = 1300.00m, CategoryId = 3, SupplierId = 2 },
                 new Product { ProductId = 3, Name = "MacBook Pro 14", Price = 2000.00m, CategoryId = 4, SupplierId = 3 },
                 new Product { ProductId = 4, Name = "Lenovo ThinkPad X1 Carbon", Price = 1500.00m, CategoryId = 5, SupplierId = 4 },
                 new Product { ProductId = 5, Name = "Dell Inspiron 15", Price = 800.00m, CategoryId = 2, SupplierId = 1 }
                 );

            modelBuilder.Entity<Stock>().HasData(
     new Stock { ProductId = 1, Type = "Supply", Quantity = 50, LastUpdate = new DateTime(2024, 03, 09, 12, 0, 0, DateTimeKind.Utc) },
     new Stock { ProductId = 1, Type = "Sale", Quantity = 20, LastUpdate = new DateTime(2024, 03, 09, 12, 5, 0, DateTimeKind.Utc) }, // فرق 5 دقائق

     new Stock { ProductId = 2, Type = "Supply", Quantity = 60, LastUpdate = new DateTime(2024, 03, 09, 12, 10, 0, DateTimeKind.Utc) },
     new Stock { ProductId = 2, Type = "Sale", Quantity = 30, LastUpdate = new DateTime(2024, 03, 09, 12, 15, 0, DateTimeKind.Utc) }, // فرق 5 دقائق

     new Stock { ProductId = 3, Type = "Supply", Quantity = 40, LastUpdate = new DateTime(2024, 03, 09, 12, 20, 0, DateTimeKind.Utc) },
     new Stock { ProductId = 3, Type = "Sale", Quantity = 10, LastUpdate = new DateTime(2024, 03, 09, 12, 25, 0, DateTimeKind.Utc) },

     new Stock { ProductId = 4, Type = "Supply", Quantity = 35, LastUpdate = new DateTime(2024, 03, 09, 12, 30, 0, DateTimeKind.Utc) },
     new Stock { ProductId = 4, Type = "Sale", Quantity = 15, LastUpdate = new DateTime(2024, 03, 09, 12, 35, 0, DateTimeKind.Utc) },

     new Stock { ProductId = 5, Type = "Supply", Quantity = 80, LastUpdate = new DateTime(2024, 03, 09, 12, 40, 0, DateTimeKind.Utc) },
     new Stock { ProductId = 5, Type = "Sale", Quantity = 50, LastUpdate = new DateTime(2024, 03, 09, 12, 45, 0, DateTimeKind.Utc) }
 );



            modelBuilder.Entity<Product>().HasData(
                new Product {ProductId = 1, Name = "Dell XPS 13", Price = 12000, CategoryId = 2, SupplierId = 1 },
                new Product {ProductId = 2, Name = "HP Spectre x360", Price = 11000, CategoryId = 3, SupplierId = 2 },
                new Product {ProductId = 3, Name = "MacBook Pro 14", Price = 20000, CategoryId = 4, SupplierId = 3 },
                new Product {ProductId = 4, Name = "Lenovo ThinkPad X1", Price = 13000, CategoryId = 5, SupplierId = 4 },
                new Product {ProductId = 5, Name = "Asus ROG Zephyrus G14", Price = 15000, CategoryId = 1, SupplierId = 5 }
            );

            modelBuilder.Entity<Stock>().HasData(
                new Stock { ProductId = 1, Type = "Supply", Quantity = 50, LastUpdate = new DateTime(2024, 9, 1) },
                new Stock { ProductId = 2, Type = "Supply", Quantity = 30, LastUpdate = new DateTime(2025, 3, 9) },
                new Stock { ProductId = 3, Type = "Supply", Quantity = 20, LastUpdate = new DateTime(2024, 2, 10) },
                new Stock { ProductId = 4, Type = "Supply", Quantity = 20, LastUpdate = new DateTime(2024, 6, 4) }
            );

            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<Sale>()
                .Property(s => s.Total_Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SalesDetails>()
                .Property(sd => sd.Price)
                .HasColumnType("decimal(18,2)");

            modelBuilder.Entity<SalesDetails>()
                .Property(sd => sd.unitPrice)
                .HasColumnType("decimal(18,2)");


            modelBuilder.Entity<SalesDetails>()
                .HasKey(sd => new { sd.ProductId, sd.SaleId });

            modelBuilder.Entity<SalesDetails>()
                .HasOne(sd => sd.Product)
                .WithMany(p => p.SalesDetails)
                .HasForeignKey(sd => sd.ProductId);

            modelBuilder.Entity<SalesDetails>()
                .HasOne(sd => sd.Sale)
                .WithMany(s => s.SalesDetails)
                .HasForeignKey(sd => sd.SaleId);

            modelBuilder.Entity<Stock>()
                .HasOne(s => s.Product)
                .WithMany(p => p.Stocks)
                .HasForeignKey(s => s.ProductId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Stock>()
                .HasKey(s => new { s.LastUpdate, s.ProductId });
        }
    }
}
