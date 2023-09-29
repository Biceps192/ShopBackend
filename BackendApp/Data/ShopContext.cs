using BackendApp.Models;
using Microsoft.EntityFrameworkCore;

namespace BackendApp.Data
{
    public class ShopContext: DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> opt) : base(opt)
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductOrder> ProductOrders { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<PublicUser> PublicUsers { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Brand> Brands { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PublicUser>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<ProductOrder>().HasKey(x => new {x.ProductId, x.OrderId});

            modelBuilder.Entity<ProductOrder>()
                .HasOne(x => x.Product)
                .WithMany(x => x.ProductOrders)
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<ProductOrder>()
                .HasOne(x => x.Order)
                .WithMany(x => x.ProductOrders)
                .HasForeignKey(x => x.OrderId);

            
        }
    }
}
