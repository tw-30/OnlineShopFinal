using Microsoft.EntityFrameworkCore;

namespace OnlineShop.Models
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 1, Name = "Laptops" },
                new Category { CategoryID = 2, Name = "Computers" },
                new Category { CategoryID = 3, Name = "Mobile Phones" }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    ProductID = 1,
                    CategoryID = 1,
                    Code = "MacPro",
                    Name = "Macbook Pro ",
                    Price = (decimal)999.00
                },
                new Product
                {
                    ProductID = 2,
                    CategoryID = 1,
                    Code = "Omen16T",
                    Name = "Omen by HP Laptop 16t-b100",
                    Price = (decimal)1099.99
                },
                new Product
                {
                    ProductID = 3,
                    CategoryID = 1,
                    Code = "Victus16T",
                    Name = "Victus by HP 16T-d100",
                    Price = (decimal)849.99
                },
                new Product
                {
                    ProductID = 4,
                    CategoryID = 1,
                    Code = "GalaxyBook",
                    Name = "Samsung Galaxy Book Pro 360",
                    Price = (decimal)999.00
                },
                new Product
                {
                    ProductID = 5,
                    CategoryID = 1,
                    Code = "Inspiron3511",
                    Name = "Dell Inspiron 3511",
                    Price = (decimal)439.99
                },
                new Product
                {
                    ProductID = 6,
                    CategoryID = 1,
                    Code = "VivoBook",
                    Name = "Asus Vivobook",
                    Price = (decimal)319.99
                },
                new Product
                {
                    ProductID = 7,
                    CategoryID = 2,
                    Code = "EnvyPC",
                    Name = "HP Envy Desktop",
                    Price = (decimal)689.99
                },
                new Product
                {
                    ProductID = 8,
                    CategoryID = 2,
                    Code = "Vengance",
                    Name = "Corsair Vengance a7200",
                    Price = (decimal)1999.99
                },
                new Product
                {
                    ProductID = 9,
                    CategoryID = 3,
                    Code = "Iphone13Pro",
                    Name = "Iphone 13 Pro",
                    Price = (decimal)999.99
                },
                new Product
                {
                    ProductID = 10,
                    CategoryID = 3,
                    Code = "GalaxyS22",
                    Name = "Samsung Galaxy S22 Ultra",
                    Price = (decimal)399.99
                }
            );
        }
    }
}