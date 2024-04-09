
using BulkyShop.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BulkyShop.DataAcess.Data
{
    public class ApplicationDbContext : IdentityDbContext<IdentityUser> 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products{ get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<ShoppingCart> ShoppingCarts { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<OrderHeader> OrderHeaders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Clothes", DisplayOrder = 1 },
                new Category { Id = 2, Name = "Gears", DisplayOrder = 2 },
                new Category { Id = 3, Name = "Supplement", DisplayOrder = 3 }
                );

            modelBuilder.Entity<Company>().HasData(
                new Company { Id = 1, Name = "Tech Solution", StreetAddress="123 Tech St", City="Tech City",
                                PostalCode="12121", State="IL", PhoneNumber="6669990000"},
                new Company {
                    Id = 2,
                    Name = "GymShark",
                    StreetAddress = "999 Vid St",
                    City = "Vid City",
                    PostalCode = "66666",
                    State = "IL",
                    PhoneNumber = "7779990000"
                },
                new Company {
                    Id = 3,
                    Name = "Gen Nutrition",
                    StreetAddress = "999 Main St",
                    City = "Lala land",
                    PostalCode = "99999",
                    State = "NY",
                    PhoneNumber = "1113335555"
                }
                );


            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage { Id = 1, ImageUrl = "images/GS-Shirt.webp", ProductId = 1 },
                new ProductImage { Id = 2, ImageUrl = "images/LS-Har.webp", ProductId = 2 },
                new ProductImage { Id = 3, ImageUrl = "images/Whey.jpg", ProductId = 3 });

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Name = "Gymshark Shirt",
                    Suppliers = "Gymshark",
                    Description = "hhhhh ",
                    Quantity = 10,
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 1
                },
                new Product
                {
                    Id = 2,
                    Name = "Lifting Straps",
                    Suppliers = "Harbinger",
                    Description = "hhhhh ",
                    Quantity = 10,
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 2
                },
                new Product
                {
                    Id = 3,
                    Name = "Whey isolate",
                    Suppliers = "Optimus Nutrition",
                    Description = "hhhhh ",
                    Quantity = 10,
                    ListPrice = 99,
                    Price = 90,
                    Price50 = 85,
                    Price100 = 80,
                    CategoryId = 3
                }
                
                );
        }
    }
}
