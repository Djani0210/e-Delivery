using e_Delivery.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace e_Delivery.Database
{
    public class eDeliveryDBContext : IdentityDbContext<User, Role, Guid>, IeDeliveryDBContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<FoodItemPictures> FoodItemPictures { get; set; }
        public DbSet<FoodItemSideDishMapping> FoodItemSideDishMappings { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<SideDish> SideDishes { get; set; }
        public DbSet<Verification> Verifications { get; set; }




        public eDeliveryDBContext(DbContextOptions<eDeliveryDBContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BaseEntity>().UseTpcMappingStrategy();

            modelBuilder.Entity<FoodItem>()
            .HasMany(e => e.SideDishes)
            .WithMany(e => e.FoodItems)
            .UsingEntity<FoodItemSideDishMapping>();


            modelBuilder.Entity<OrderItem>()
            .HasKey(o => o.Id);  // Define the Id property as the primary key

            modelBuilder.Entity<OrderItem>()
                .Property(o => o.SideDishIds)
                .HasConversion(
                    v => string.Join(',', v),            // Convert List<int> to a string
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()  // Convert back to List<int>
                );

          

            modelBuilder.Entity<Restaurant>()
            .HasOne(r => r.CreatedByUser)
            .WithMany()
            .HasForeignKey(r => r.CreatedByUserId);

            modelBuilder.Entity<Restaurant>()
            .HasOne(r => r.ModifiedByUser)
            .WithMany()
            .HasForeignKey(r => r.ModifiedByUserId);




            //modelBuilder.Ignore<BaseEntity>();

            //modelBuilder.Entity<User>()
            //.HasOne(u => u.City)
            //.WithMany()
            //.HasForeignKey(u => u.CityId)
            //.OnDelete(DeleteBehavior.Restrict); // Adjust the delete behavior as needed

            //modelBuilder.Entity<BaseEntity>()
            //    .HasOne(b => b.CreatedByUser)   
            //    .WithMany()
            //    .HasForeignKey(b => b.CreatedByUserId)
            //    .OnDelete(DeleteBehavior.Restrict); // Adjust the delete behavior as needed

            //modelBuilder.Entity<BaseEntity>()
            //    .HasOne(b => b.ModifiedByUser)
            //    .WithMany()
            //    .HasForeignKey(b => b.ModifiedByUserId)
            //    .OnDelete(DeleteBehavior.Restrict); // Adjust the delete behavior as needed

            //modelBuilder.Entity<Chat>()
            //.HasOne(c => c.UserFrom)
            //.WithMany()
            //.HasForeignKey(c => c.UserFromId)
            //.OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<Chat>()
            //    .HasOne(c => c.UserTo)
            //    .WithMany()
            //    .HasForeignKey(c => c.UserToId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //modelBuilder.Entity<FoodItemSideDishMapping>()
            //.HasKey(mapping => new { mapping.FoodItemId, mapping.SideDishId });

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("asp_net_users", "identity");
            modelBuilder.Entity<Role>().ToTable("asp_net_roles", "identity");
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("asp_net_user_claims", "identity");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("asp_net_user_roles", "identity");
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("asp_net_user_logins", "identity");
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("asp_net_role_claims", "identity");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("asp_net_user_tokens", "identity");

        }
    }
}
