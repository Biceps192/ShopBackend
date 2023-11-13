using BackendApp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

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
        public DbSet<ProductBasket> ProductBasket { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<PublicUser> PublicUsers { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Brand> Brands { get; set; }


        //public override int SaveChanges()
        //{
        //    DateTimeOffset currentDateTime = DateTimeOffset.Now;

        //    // get all the entities in the change tracker - this could be optimized
        //    // to fetch only the entities with "State == added" if that's the only 
        //    // case you want to handle
        //    IEnumerable<EntityEntry<AuditExtensions>> entities = ChangeTracker.Entries<AuditExtensions>();

        //    // handle newly added entities
        //    foreach (EntityEntry<AuditExtensions> entity in entities.Where(e => e.State == EntityState.Added))
        //    {
        //        // set the CreatedOn field to the current date&time
        //        entity.Entity.CreatedAt = currentDateTime;
        //        entity.Entity.ModifiedAt = currentDateTime;
        //    }

        //    // to the actual saving of the data
        //    return base.SaveChanges();
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PublicUser>().HasIndex(x => x.Email).IsUnique();
            modelBuilder.Entity<ProductBasket>().HasKey(x => new { x.ProductId, x.BasketId });

            modelBuilder.Entity<ProductBasket>()
                .HasOne(x => x.Product)
                .WithMany(x => x.ProductBasket)
                .HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<ProductBasket>()
                .HasOne(x => x.Basket)
                .WithMany(x => x.ProductBasket)
                .HasForeignKey(x => x.BasketId);

            modelBuilder.Entity<PublicUser>()
            .HasOne(pu => pu.Basket)
            .WithOne(b => b.PublicUser)
            .HasForeignKey<Basket>(b => b.PublicUserId);

            modelBuilder.Seed();
            
        }
    }
}

