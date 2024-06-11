using e_Delivery.Database.DataSeed;
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
        public DbSet<Notification> Notifications { get; set; }





        public eDeliveryDBContext(DbContextOptions<eDeliveryDBContext> options) : base(options)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<FoodItem>()
            .HasMany(e => e.SideDishes)
            .WithMany(e => e.FoodItems)
            .UsingEntity<FoodItemSideDishMapping>();


            modelBuilder.Entity<OrderItem>()
            .HasKey(o => o.Id);

            modelBuilder.Entity<OrderItem>()
                .Property(o => o.SideDishIds)
                .HasConversion(
                    v => string.Join(',', v),
                    v => v.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList()
                );

            modelBuilder.Entity<FoodItemSideDishMapping>()
    .HasOne(m => m.FoodItem)
    .WithMany(fi => fi.FoodItemSideDishMappings)
    .HasForeignKey(m => m.FoodItemId)
    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<FoodItemSideDishMapping>()
                .HasOne(m => m.SideDish)
                .WithMany(sd => sd.FoodItemSideDishMappings)
                .HasForeignKey(m => m.SideDishId)
                .OnDelete(DeleteBehavior.NoAction);


            modelBuilder.Entity<Restaurant>()
            .HasOne(r => r.CreatedByUser)
            .WithMany()
            .HasForeignKey(r => r.CreatedByUserId).OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<Restaurant>()
            .HasOne(r => r.ModifiedByUser)
            .WithMany()
            .HasForeignKey(r => r.ModifiedByUserId).OnDelete(DeleteBehavior.NoAction); 


            modelBuilder.Entity<FoodItem>()
            .HasMany(fi => fi.FoodItemPictures)
            .WithOne(fip => fip.FoodItem)
            .HasForeignKey(fip => fip.FoodItemId)
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<OrderItemSideDish>()
        .HasKey(ois => new { ois.OrderItemId, ois.SideDishId });

            modelBuilder.Entity<OrderItemSideDish>()
                .HasOne(ois => ois.OrderItem)
                .WithMany(oi => oi.OrderItemSideDishes)
                .HasForeignKey(ois => ois.OrderItemId)
                .OnDelete(DeleteBehavior.NoAction); 

            modelBuilder.Entity<OrderItemSideDish>()
                .HasOne(ois => ois.SideDish)
                .WithMany(sd => sd.OrderItemSideDishes)
                .HasForeignKey(ois => ois.SideDishId).OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Chat>()
    .HasOne(c => c.UserFrom)
    .WithMany()
    .HasForeignKey(c => c.UserFromId)
    .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Chat>()
                .HasOne(c => c.UserTo)
                .WithMany()
                .HasForeignKey(c => c.UserToId)
                .OnDelete(DeleteBehavior.NoAction);




            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable("asp_net_users", "identity");
            modelBuilder.Entity<Role>().ToTable("asp_net_roles", "identity");
            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("asp_net_user_claims", "identity");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("asp_net_user_roles", "identity");
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("asp_net_user_logins", "identity");
            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("asp_net_role_claims", "identity");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("asp_net_user_tokens", "identity");



            #region SEED
            modelBuilder.Entity<Category>().HasData(DefaultCategoryData.Categories);
            modelBuilder.Entity<City>().HasData(DefaultCityData.Cities);
            modelBuilder.Entity<User>().HasData(DefaultUserData.Users);
            modelBuilder.Entity<Role>().HasData(DefaultRoleData.Roles);
            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(DefaultUserRoleData.UserRoles);
            modelBuilder.Entity<Location>().HasData(DefaultLocationData.Locations);
            modelBuilder.Entity<Image>().HasData(DefaultImageData.Images);
            modelBuilder.Entity<Restaurant>().HasData(DefaultRestaurantData.Restaurants);
            modelBuilder.Entity<FoodItem>().HasData(DefaultFoodItemData.FoodItems);
            modelBuilder.Entity<SideDish>().HasData(DefaultSideDishData.SideDishes);
            modelBuilder.Entity<FoodItemPictures>().HasData(DefaultFoodItemPicturesData.FoodItemPictures);
            modelBuilder.Entity<FoodItemSideDishMapping>().HasData(DefaultFoodItemSideDishMappingData.FoodItemSideDishMappings);
            modelBuilder.Entity<Order>().HasData(DefaultOrderData.Orders);
            modelBuilder.Entity<OrderItem>().HasData(DefaultOrderItemData.OrderItems);
            modelBuilder.Entity<OrderItemSideDish>().HasData(DefaultOrderItemSideDishData.OrderItemSideDishes);
            modelBuilder.Entity<Review>().HasData(DefaultReviewData.Reviews);
            modelBuilder.Entity<Chat>().HasData(DefaultChatData.Chats);
            modelBuilder.Entity<Notification>().HasData(DefaultNotificationData.Notifications);

            #endregion

        }
    }
}
