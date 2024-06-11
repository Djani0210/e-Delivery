using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "identity");

            migrationBuilder.CreateTable(
                name: "asp_net_roles",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_net_roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_role_claims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_net_role_claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_asp_net_role_claims_asp_net_roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "asp_net_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_user_claims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_net_user_claims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_user_logins",
                schema: "identity",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_net_user_logins", x => new { x.LoginProvider, x.ProviderKey });
                });

            migrationBuilder.CreateTable(
                name: "asp_net_user_roles",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_net_user_roles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_asp_net_user_roles_asp_net_roles_RoleId",
                        column: x => x.RoleId,
                        principalSchema: "identity",
                        principalTable: "asp_net_roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "asp_net_user_tokens",
                schema: "identity",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_net_user_tokens", x => new { x.UserId, x.LoginProvider, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "asp_net_users",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true),
                    WorkFrom = table.Column<TimeSpan>(type: "time", nullable: true),
                    WorkUntil = table.Column<TimeSpan>(type: "time", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: true),
                    CityId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_net_users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_asp_net_users_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Chats",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserFromId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserToId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chats", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Chats_asp_net_users_UserFromId",
                        column: x => x.UserFromId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Chats_asp_net_users_UserToId",
                        column: x => x.UserToId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Emails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Emails_asp_net_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserProfilePictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_asp_net_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_asp_net_users_ModifiedByUserId",
                        column: x => x.ModifiedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Images_asp_net_users_UserProfilePictureId",
                        column: x => x.UserProfilePictureId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Longitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Latitude = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Locations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Locations_asp_net_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Locations_asp_net_users_ModifiedByUserId",
                        column: x => x.ModifiedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SentByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SentToUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Notifications_asp_net_users_SentByUserId",
                        column: x => x.SentByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Notifications_asp_net_users_SentToUserId",
                        column: x => x.SentToUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Verifications",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Verifications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Verifications_asp_net_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Restaurants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOpen = table.Column<bool>(type: "bit", nullable: false),
                    OpeningTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ClosingTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeliveryCharge = table.Column<double>(type: "float", nullable: false),
                    DeliveryTime = table.Column<int>(type: "int", nullable: false),
                    LocationId = table.Column<int>(type: "int", nullable: true),
                    LogoId = table.Column<int>(type: "int", nullable: true),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Restaurants", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Restaurants_Images_LogoId",
                        column: x => x.LogoId,
                        principalTable: "Images",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_asp_net_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Restaurants_asp_net_users_ModifiedByUserId",
                        column: x => x.ModifiedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FoodItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItems_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodItems_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodItems_asp_net_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodItems_asp_net_users_ModifiedByUserId",
                        column: x => x.ModifiedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PaymentMethod = table.Column<int>(type: "int", nullable: false),
                    TotalCost = table.Column<double>(type: "float", nullable: false),
                    Allergies = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrderState = table.Column<int>(type: "int", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    DeliveryPersonAssignedId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Locations_LocationId",
                        column: x => x.LocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_asp_net_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_asp_net_users_DeliveryPersonAssignedId",
                        column: x => x.DeliveryPersonAssignedId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedByUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Grade = table.Column<double>(type: "float", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Reviews_asp_net_users_CreatedByUserId",
                        column: x => x.CreatedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Reviews_asp_net_users_ModifiedByUserId",
                        column: x => x.ModifiedByUserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SideDishes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SideDishes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SideDishes_Restaurants_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodItemPictures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileSize = table.Column<int>(type: "int", nullable: false),
                    FoodItemId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemPictures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodItemPictures_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    SideDishIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Cost = table.Column<double>(type: "float", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderItems_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FoodItemSideDishMappings",
                columns: table => new
                {
                    FoodItemId = table.Column<int>(type: "int", nullable: false),
                    SideDishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodItemSideDishMappings", x => new { x.FoodItemId, x.SideDishId });
                    table.ForeignKey(
                        name: "FK_FoodItemSideDishMappings_FoodItems_FoodItemId",
                        column: x => x.FoodItemId,
                        principalTable: "FoodItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_FoodItemSideDishMappings_SideDishes_SideDishId",
                        column: x => x.SideDishId,
                        principalTable: "SideDishes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OrderItemSideDish",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    SideDishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemSideDish", x => new { x.OrderItemId, x.SideDishId });
                    table.ForeignKey(
                        name: "FK_OrderItemSideDish_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OrderItemSideDish_SideDishes_SideDishId",
                        column: x => x.SideDishId,
                        principalTable: "SideDishes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6935), false, "Burger" },
                    { 2, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6972), false, "Pizza" },
                    { 3, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6974), false, "Pasta" },
                    { 4, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6976), false, "Sea Food" },
                    { 5, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6977), false, "Grill" },
                    { 6, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6982), false, "Vegetarian" },
                    { 7, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6983), false, "Vegan" },
                    { 8, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6985), false, "Sandwich" },
                    { 9, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6986), false, "Cooked dishes" },
                    { 10, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6988), false, "Cakes" },
                    { 11, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6990), false, "Pancakes" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "CreatedDate", "IsDeleted", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7104), false, "Mostar" },
                    { 2, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7109), false, "Sarajevo" },
                    { 3, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7111), false, "Zenica" },
                    { 4, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7112), false, "Tuzla" },
                    { 5, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7114), false, "Banja Luka" },
                    { 6, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7116), false, "Bihać" },
                    { 7, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7117), false, "Bijeljina" },
                    { 8, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7119), false, "Brčko" },
                    { 9, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7121), false, "Cazin" },
                    { 10, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7123), false, "Čapljina" },
                    { 11, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7124), false, "Derventa" },
                    { 12, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7126), false, "Doboj" },
                    { 13, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7127), false, "Goražde" },
                    { 14, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7129), false, "Gračanica" },
                    { 15, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7130), false, "Gradačac" },
                    { 16, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7132), false, "Gradiška" },
                    { 17, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7133), false, "Konjic" },
                    { 18, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7136), false, "Laktaši" },
                    { 19, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7137), false, "Livno" },
                    { 20, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7139), false, "Lukavac" },
                    { 21, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7140), false, "Ljubuški" },
                    { 22, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7142), false, "Orašje" },
                    { 23, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7143), false, "Prijedor" },
                    { 24, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7145), false, "Prnjavor" },
                    { 25, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7147), false, "Srebrenik" },
                    { 26, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7148), false, "Stolac" },
                    { 27, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7149), false, "Široki Brijeg" },
                    { 28, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7151), false, "Trebinje" },
                    { 29, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7153), false, "Visoko" },
                    { 30, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7154), false, "Zavidovići" },
                    { 31, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7156), false, "Zvornik" },
                    { 32, new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7157), false, "Živinice" }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "asp_net_roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "IsDeleted", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"), "4b7b90a8-799b-4d5c-9c9e-11ee630a7d48", null, false, "Admin", null },
                    { new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"), "ef4d26e8-df82-42ef-aeaa-7a4b2c9975ea", null, false, "MobileCustomer", null },
                    { new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"), "d9d6c9c7-9c6b-47da-badf-19cb447a908e", null, false, "MobileDeliveryPerson", null },
                    { new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"), "b5e09401-bbbe-4ab7-b6f0-f9b03a462ad0", null, false, "Desktop", null }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "asp_net_users",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "Gender", "IsAvailable", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpireDate", "RestaurantId", "SecurityStamp", "TwoFactorEnabled", "UserName", "WorkFrom", "WorkUntil" },
                values: new object[,]
                {
                    { new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), 0, 1, "b8c107a8-06be-416a-9ddb-a020464ae1f3", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "mobilecustomer1@gmail.com", false, "Customer1", 1, true, false, "User1", false, null, "MOBILECUSTOMER1@GMAIL.COM", "MOBILECUSTOMER1", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "805f80e9-8118-48bc-8677-f5ac1625de74", false, "MobileCustomer1", null, null },
                    { new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"), 0, 1, "b4ac1b1b-4c17-4af0-8b1f-f822ca7809ea", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "edeliveryadmin@gmail.com", false, "Admin", 1, true, false, "Admin", false, null, "EMPLOYEE@EMPLOYEE.COM", "ADMIN", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "061-502-342", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "726897f4-76fe-4e7f-bcd6-890753ead106", false, "admin", null, null },
                    { new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), 0, 1, "b3f1dadd-c6bc-4f2f-a56c-41e2ed79fd48", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "mobilecustomer2@gmail.com", false, "Custome2", 1, true, false, "User2", false, null, "MOBILECUSTOMER2@GMAIL.COM", "MOBILECUSTOMER2", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "b497d406-5453-438e-9bd4-71177d6ca9b8", false, "MobileCustomer2", null, null },
                    { new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), 0, 1, "c97e47b7-e862-4930-abab-39859961a1cf", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "desktop3edelivery@gmail.com", false, "desktop3", 1, true, false, "User3", false, null, "DESKTOP3EDELIVERY@GMAIL.COM", "DESKTOP3", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "061-111-114", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "878ff0d8-bc79-49fa-b9a5-a862541efb9e", false, "desktop3", null, null },
                    { new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), 0, 1, "219c6691-86e9-437b-9bf8-c1ef24babdd3", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "desktop4edelivery@gmail.com", false, "desktop4", 1, true, false, "User4", false, null, "DESKTOP4EDELIVERY@GMAIL.COM", "DESKTOP4", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "bbf2fef1-693a-4926-8057-228dc4fe314b", false, "desktop4", null, null },
                    { new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), 0, 1, "64494c1f-d7b6-4670-a638-c4383a71dec1", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "desktop2edelivery@gmail.com", false, "desktop2", 1, true, false, "User2", false, null, "DESKTOP2EDELIVERY@GMAIL.COM", "DESKTOP2", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "061-111-113", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "02df7035-72bf-4e81-ac4c-8ccedb195ccc", false, "desktop2", null, null },
                    { new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), 0, 1, "a706e15e-04ab-47bf-8d53-7d29e147c8a5", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "kupac11111@gmail.com", false, "Customer", 1, true, false, "User", false, null, "KUPAC11111@GMAIL.COM", "MOBILECUSTOMER", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "cf0c17c1-7f70-4de8-9dc6-24c25334c1a2", false, "MobileCustomer", null, null },
                    { new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), 0, 1, "ba1954c0-c343-4028-bd5c-39857b24728b", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "desktop1edelivery@gmail.com", false, "desktop1", 1, true, false, "User1", false, null, "DESKTOP1EDELIVERY@GMAIL.COM", "DESKTOP1", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "061-111-112", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "a37dc3d1-2722-4900-a15d-99ac6f9ffb95", false, "desktop1", null, null },
                    { new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"), 0, 1, "5cc55d81-94e0-4c30-8648-afaebb1cf7ff", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "desktop6edelivery@gmail.com", false, "desktop6", 1, true, false, "User6", false, null, "DESKTOP6EDELIVERY@GMAIL.COM", "DESKTOP6", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "5fb231ab-6419-4e2f-bc7a-471df74819dd", false, "desktop6", null, null },
                    { new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), 0, 1, "c0e32b0c-97f0-42ca-9ca6-a88d5d9dcd92", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "desktop5edelivery@gmail.com", false, "desktop5", 1, true, false, "User5", false, null, "DESKTOP5EDELIVERY@GMAIL.COM", "DESKTOP5", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "0231e462-3830-4bfd-b664-17852d6c3357", false, "desktop5", null, null },
                    { new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), 0, 1, "1547feec-6731-459e-8edf-39f5d798b878", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "belminedelivery@gmail.com", false, "desktop", 1, true, false, "User", false, null, "BELMINEDELIVERY@GMAIL.COM", "DESKTOP", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "061-111-111", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "8673c57f-d8ce-4c30-a4b2-87048729bf1b", false, "desktop", null, null }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "IsDeleted", "ModifiedByUserId", "Path", "UserProfilePictureId" },
                values: new object[,]
                {
                    { 1, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7723), false, null, "/Uploads/Images/f4af967c-1d73-4f02-a576-75e72d542411.jpg", null },
                    { 2, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7727), false, null, "/Uploads/Images/a38064f5-960d-43ce-9597-ed27fd588419.jpg", null },
                    { 3, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7729), false, null, "/Uploads/Images/radobolja.jpg", null },
                    { 4, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7732), false, null, "/Uploads/Images/dva-fenjera.jpg", null },
                    { 5, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7734), false, null, "/Uploads/Images/48d82799-50bb-46c7-a655-f6860c8877a9.jpg", null },
                    { 6, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7737), false, null, "/Uploads/Images/megi.jpg", null },
                    { 10, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7749), false, null, "/Uploads/Images/customer.jpg", new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { 11, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7752), false, null, "/Uploads/Images/customer1.jpg", new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9") },
                    { 12, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7755), false, null, "/Uploads/Images/customer2.jpg", new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257") }
                });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CityId", "CreatedByUserId", "CreatedDate", "IsDeleted", "Latitude", "Longitude", "ModifiedByUserId" },
                values: new object[,]
                {
                    { 1, 1, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7643), false, "43.34205", "17.80042", null },
                    { 2, 1, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7651), false, "43.34042", "17.81526", null },
                    { 3, 1, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7654), false, "43.33947", "17.80315", null },
                    { 4, 1, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7657), false, "43.31130", "17.83038", null },
                    { 5, 1, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7659), false, "43.33823", "17.81019", null },
                    { 6, 1, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7662), false, "43.35016", "17.80079", null },
                    { 7, 1, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7665), false, "43.34731", "17.81352", null },
                    { 8, 1, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7667), false, "43.34745", "17.81166", null },
                    { 9, 1, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7669), false, "43.34666", "17.80534", null },
                    { 10, 1, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7672), false, "43.34988", "17.80171", null },
                    { 11, 1, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7674), false, "43.33786", "17.81581", null },
                    { 12, 1, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7676), false, "43.34458", "17.81346", null },
                    { 13, 1, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7679), false, "43.34731", "17.81352", null },
                    { 14, 1, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7681), false, "43.34745", "17.81166", null },
                    { 15, 1, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7683), false, "43.34666", "17.80534", null },
                    { 16, 1, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7685), false, "43.34988", "17.80171", null },
                    { 17, 1, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7687), false, "43.33786", "17.81581", null },
                    { 18, 1, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7690), false, "43.34458", "17.81346", null },
                    { 19, 1, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7692), false, "43.34731", "17.81352", null },
                    { 20, 1, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7694), false, "43.34745", "17.81166", null },
                    { 21, 1, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7696), false, "43.34666", "17.80534", null },
                    { 22, 1, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7698), false, "43.34988", "17.80171", null },
                    { 23, 1, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7700), false, "43.33786", "17.81581", null },
                    { 24, 1, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7703), false, "43.34458", "17.81346", null }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "asp_net_user_roles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"), new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9") },
                    { new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"), new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678") },
                    { new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"), new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257") },
                    { new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"), new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f") },
                    { new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"), new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39") },
                    { new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"), new Guid("a6262414-844d-4003-9184-1a39fcc8d621") },
                    { new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"), new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310") },
                    { new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"), new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7") },
                    { new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"), new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671") },
                    { new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"), new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b") }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "Id", "Address", "ClosingTime", "ContactNumber", "CreatedByUserId", "CreatedDate", "DeliveryCharge", "DeliveryTime", "IsOpen", "LocationId", "LogoId", "ModifiedByUserId", "Name", "OpeningTime" },
                values: new object[,]
                {
                    { 1, "Zagrebačka 6", new TimeSpan(0, 20, 0, 0, 0), "063-123-123", new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7778), 2.5, 40, true, 1, 1, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Aldi - Caffe slastičarna", new TimeSpan(0, 8, 0, 0, 0) },
                    { 2, "Brkića 1a", new TimeSpan(0, 22, 0, 0, 0), "063-123-124", new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7813), 2.0, 30, true, 2, 2, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Porto Pizza Mostar", new TimeSpan(0, 8, 0, 0, 0) },
                    { 3, "Kraljice Katarine 11a", new TimeSpan(0, 21, 0, 0, 0), "063-123-125", new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7818), 3.0, 45, true, 3, 3, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Restoran Radobolja", new TimeSpan(0, 10, 0, 0, 0) },
                    { 4, "Bišće Polje, M17", new TimeSpan(0, 21, 0, 0, 0), "063-123-126", new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7821), 3.0, 50, true, 4, 4, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Dva fenjera", new TimeSpan(0, 10, 0, 0, 0) },
                    { 5, "Husnije Repca 3", new TimeSpan(0, 21, 0, 0, 0), "063-123-127", new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7824), 1.5, 30, true, 5, 5, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Niđe veze", new TimeSpan(0, 10, 0, 0, 0) },
                    { 6, "Kralja Tomislava 9", new TimeSpan(0, 21, 0, 0, 0), "063-123-128", new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7828), 2.5, 35, true, 6, 6, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Megi Le Petit", new TimeSpan(0, 10, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "FoodItems",
                columns: new[] { "Id", "CategoryId", "CreatedByUserId", "CreatedDate", "Description", "IsAvailable", "IsDeleted", "ModifiedByUserId", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 1, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7866), "Juicy beef patty with tomato, salad, onions", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Hamburger", 9.0, 1 },
                    { 2, 1, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7873), "Juicy beef patty with tomato, salad, onions and cheese", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Cheeseburger", 11.0, 1 },
                    { 3, 2, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7877), "Regular pizza with Gauda cheese", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Margarita", 9.0, 1 },
                    { 4, 2, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7880), "Pizza with salami and mushrooms", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Capricciosa", 11.0, 1 },
                    { 5, 2, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7883), "Pizza with mushrooms", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Funghi", 10.0, 1 },
                    { 6, 5, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7887), "Grilled chicken 100g", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Chicken fillet", 9.0, 1 },
                    { 7, 5, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7890), "Lamb sausages 100g", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Sausages", 9.0, 1 },
                    { 8, 8, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7893), "Salami-cheese sandwich with tomato, lettuce and onions", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Classic sandwich", 9.0, 1 },
                    { 9, 8, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7896), "Chicken sandwich with tomato, lettuce and onions", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Chicken sandwich", 10.0, 1 },
                    { 10, 8, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7900), "Pepperoni sandwich with tomato, lettuce and onions", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Pepperoni sandwich", 10.0, 1 },
                    { 11, 10, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7903), "Homemade chocolate cake, original recipe", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Sacher-Torte", 4.0, 1 },
                    { 12, 10, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7906), "Homemade baklava, original recipe", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Baklava", 4.0, 1 },
                    { 13, 11, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7909), "Nutella filled pancakakes", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Nutella pancakes", 7.0, 1 },
                    { 14, 11, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7912), "Strawberry jam filled pancakakes", true, false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), "Jam pancakes", 6.0, 1 },
                    { 15, 2, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7916), "Regular pizza with cheese", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Margarita", 8.0, 2 },
                    { 16, 2, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7920), "Pizza with salami and mushrooms", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Capricciosa", 10.0, 2 },
                    { 17, 2, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1521), "Pizza with mushrooms", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Funghi", 9.0, 2 },
                    { 18, 2, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1551), "Pizza with pepperoni sausage", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Pepperoni", 11.0, 2 },
                    { 19, 5, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1555), "Chicken grilled fillets 100g", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Chicken fillets", 9.0, 2 },
                    { 20, 5, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1559), "5 ćevapi with bread and onions", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "ćevapi small portion", 5.0, 2 },
                    { 21, 5, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1562), "10 ćevapi with bread and onions", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "ćevapi large portion", 9.0, 2 },
                    { 22, 6, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1566), "", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Greek salad", 6.0, 2 },
                    { 23, 7, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1569), "Tomato and onions", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Tomato salad", 4.0, 2 },
                    { 24, 7, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1573), "Lettuce, tomato and onions", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Regular salad", 4.0, 2 },
                    { 25, 8, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1576), "Salami and cheese with lettuce, tomato and onions", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Classic sandwich ", 6.0, 2 },
                    { 26, 8, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1579), "Chicken and cheese with lettuce, tomato and onions", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Chicken sandwich ", 7.5, 2 },
                    { 27, 11, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1583), "Pancakes filled with nutella", true, false, new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"), "Nutella pancakes ", 7.0, 2 },
                    { 28, 4, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1625), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Stuffed squid", 15.0, 3 },
                    { 29, 4, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1630), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Fried squid", 15.0, 3 },
                    { 30, 4, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1633), "Filled with cream", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Neretvan trout filled", 15.0, 3 },
                    { 31, 4, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1637), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Neretvan trout", 13.0, 3 },
                    { 32, 5, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1640), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Beefsteak", 20.0, 3 },
                    { 33, 5, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1642), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Chicken skewers small", 6.0, 3 },
                    { 34, 5, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1646), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Chicken skewers large", 10.0, 3 },
                    { 35, 5, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1649), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Ćevapi (small)", 5.0, 3 },
                    { 36, 5, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1652), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Ćevapi (large)", 9.0, 3 },
                    { 37, 7, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1655), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Green salad", 3.0, 3 },
                    { 38, 7, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1659), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Tomato salad", 3.0, 3 },
                    { 39, 6, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1662), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Salad with cheese", 4.0, 3 },
                    { 40, 11, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1665), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Nutella pancakes", 6.0, 3 },
                    { 41, 10, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1669), "", true, false, new Guid("a6262414-844d-4003-9184-1a39fcc8d621"), "Baklava", 4.0, 3 },
                    { 42, 5, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1671), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Ćevapi (small)", 5.0, 4 },
                    { 43, 5, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1675), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Ćevapi (large)", 9.0, 4 },
                    { 44, 5, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1678), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Chicken fillets", 6.0, 4 },
                    { 45, 11, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1682), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Nutella pancakes", 6.0, 4 },
                    { 46, 10, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1685), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Baklava", 4.0, 4 },
                    { 47, 9, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1688), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Dolma", 8.0, 4 },
                    { 48, 9, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1690), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Japrak", 7.0, 4 },
                    { 49, 9, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1693), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Biber meso", 8.5, 4 },
                    { 50, 9, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1697), "", true, false, new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"), "Bosnian pot", 7.0, 4 },
                    { 51, 1, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1700), "Juicy beef patty with tomato, salad, onions", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Hamburger", 9.0, 5 },
                    { 52, 1, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1704), "Juicy beef patty with tomato, salad, onions and cheese", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Cheeseburger", 11.0, 5 },
                    { 53, 2, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1707), "Regular pizza with Gauda cheese", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Margarita", 9.0, 5 },
                    { 54, 2, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1710), "Pizza with salami and mushrooms", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Capricciosa", 11.0, 5 },
                    { 55, 6, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1713), "", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Salad with cheese", 4.0, 5 },
                    { 56, 5, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1716), "", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Chicken fillets", 6.0, 5 },
                    { 57, 8, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1719), "Salami and cheese with lettuce, tomato and onions", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Classic sandwich ", 6.0, 5 },
                    { 58, 8, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1723), "Chicken and cheese with lettuce, tomato and onions", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Chicken sandwich ", 7.5, 5 },
                    { 59, 10, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1726), "Homemade baklava, original recipe", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Baklava", 4.0, 5 },
                    { 60, 11, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1756), "Nutella filled pancakakes", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Nutella pancakes", 7.0, 5 },
                    { 61, 11, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1759), "Strawberry jam filled pancakakes", true, false, new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"), "Jam pancakes", 6.0, 5 },
                    { 62, 2, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1763), "Regular pizza with Gauda cheese", true, false, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Margarita", 9.0, 6 },
                    { 63, 2, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1766), "Pizza with salami and mushrooms", true, false, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Capricciosa", 11.0, 6 },
                    { 64, 3, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1769), "", true, false, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Carbonara", 11.0, 6 },
                    { 65, 3, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1772), "", true, false, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Bolognese", 12.0, 6 },
                    { 66, 3, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1776), "", true, false, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Pesto", 10.0, 6 },
                    { 67, 3, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1779), "", true, false, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Lasagne bolognese", 14.0, 6 },
                    { 68, 10, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1782), "", true, false, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Baklava", 4.0, 6 },
                    { 69, 11, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1785), "", true, false, new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"), "Jam pancakes", 6.0, 6 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "Allergies", "CreatedByUserId", "CreatedDate", "DeliveryPersonAssignedId", "IsDeleted", "IsPaid", "LocationId", "OrderState", "PaymentMethod", "RestaurantId", "TotalCost" },
                values: new object[,]
                {
                    { new Guid("0167003f-76d8-4736-9010-9f4f756c5107"), "6th street", "None", new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2253), null, false, true, 22, 1, 1, 4, 21.0 },
                    { new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"), "123 Main St", "None", new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2212), null, false, true, 9, 1, 1, 1, 30.0 },
                    { new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"), "6th street", "None", new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2238), null, false, true, 17, 1, 1, 5, 48.0 },
                    { new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"), "6th street", "None", new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2225), null, false, true, 13, 1, 1, 1, 50.0 },
                    { new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"), "6th street", "None", new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2260), null, false, true, 24, 1, 1, 6, 34.0 },
                    { new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"), "6th street", "None", new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2256), null, false, true, 23, 1, 1, 5, 48.0 },
                    { new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"), "6th street", "None", new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2232), null, false, true, 15, 1, 1, 3, 12.0 },
                    { new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"), "6th street", "None", new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2241), null, false, true, 18, 1, 1, 6, 34.0 },
                    { new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"), "6th street", "None", new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2229), null, false, true, 14, 1, 1, 2, 36.0 },
                    { new Guid("5fd9e288-163c-4286-bb40-02213f53198f"), "6th street", "None", new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2247), null, false, true, 20, 1, 1, 2, 36.0 },
                    { new Guid("650327a7-1218-4306-aca5-cb30ef57de36"), "6th street", "None", new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2250), null, false, true, 21, 1, 1, 3, 12.0 },
                    { new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"), "6th street", "None", new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2235), null, false, true, 16, 1, 1, 4, 21.0 },
                    { new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"), "123 Main St", "Maybe a little cream is bad", new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2219), null, false, true, 11, 1, 1, 1, 26.0 },
                    { new Guid("faf51d20-4224-4894-940e-1d916274b611"), "123 Main St", "None", new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2193), null, false, true, 7, 1, 1, 1, 50.0 },
                    { new Guid("ff454850-5665-4246-aa6f-738cb80aa325"), "6th street", "None", new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2244), null, false, true, 19, 1, 1, 1, 50.0 }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "Description", "Grade", "IsDeleted", "ModifiedByUserId", "RestaurantId" },
                values: new object[,]
                {
                    { 1, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2393), "Great food!", 5.0, false, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), 1 },
                    { 2, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2399), "Very good food!", 4.5, false, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), 1 },
                    { 3, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2403), "Solid food!", 4.0, false, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), 1 },
                    { 4, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2406), "Very good food!", 4.5, false, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), 2 },
                    { 5, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2410), "Solid food!", 4.0, false, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), 2 },
                    { 6, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2413), "Very good food!", 5.0, false, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), 3 },
                    { 7, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2416), "Solid food!", 4.5, false, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), 3 },
                    { 8, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3002), "Very good food!", 3.5, false, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), 4 },
                    { 9, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3009), "Solid food!", 4.0, false, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), 4 },
                    { 10, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3016), "Very good food!", 4.5, false, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), 5 },
                    { 11, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3018), "Solid food!", 2.0, false, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), 5 },
                    { 12, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3055), "Very good food!", 2.5, false, new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"), 6 },
                    { 13, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3058), "Solid food!", 3.0, false, new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"), 6 }
                });

            migrationBuilder.InsertData(
                table: "SideDishes",
                columns: new[] { "Id", "IsAvailable", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, true, "Mayonnaise", 1.0, 1 },
                    { 2, true, "Ketchup", 1.0, 1 },
                    { 3, true, "Tartar sauce", 1.0, 1 },
                    { 4, true, "French fries", 2.5, 1 },
                    { 5, true, "Extra cheese", 1.5, 1 },
                    { 6, true, "Ice cream", 2.0, 1 },
                    { 7, true, "Mayonnaise", 1.0, 2 },
                    { 8, true, "Ketchup", 1.0, 2 },
                    { 9, true, "Tartar sauce", 1.0, 2 },
                    { 10, true, "Cream", 0.5, 2 },
                    { 11, true, "French fries", 2.5, 3 },
                    { 12, true, "Mayonnaise", 1.5, 3 },
                    { 13, true, "Ketchup", 1.5, 3 },
                    { 14, true, "Ajvar", 1.5, 3 },
                    { 15, true, "Barbecue sauce", 2.5, 3 },
                    { 16, true, "Soy sauce", 2.0, 3 },
                    { 17, true, "Vinegar", 2.0, 3 },
                    { 18, true, "Hot sauce", 2.0, 3 },
                    { 19, true, "Prosciutto", 2.5, 4 },
                    { 20, true, "Kajmak", 1.5, 4 },
                    { 21, true, "Sour cream", 1.5, 4 },
                    { 22, true, "Mayonaisse", 1.5, 5 },
                    { 23, true, "Ketchup", 1.5, 5 },
                    { 24, true, "Tartar sauce", 1.5, 5 },
                    { 25, true, "Ice cream", 1.5, 5 },
                    { 26, true, "Whipped cream", 0.5, 5 },
                    { 27, true, "Vinegar", 1.5, 5 },
                    { 28, true, "Vinegar", 1.5, 6 },
                    { 29, true, "Mayonnaise", 1.5, 6 },
                    { 30, true, "Ketchup", 1.5, 6 },
                    { 31, true, "Extra cheese", 1.5, 6 }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "asp_net_users",
                columns: new[] { "Id", "AccessFailedCount", "CityId", "ConcurrencyStamp", "CreatedDate", "Email", "EmailConfirmed", "FirstName", "Gender", "IsAvailable", "IsDeleted", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpireDate", "RestaurantId", "SecurityStamp", "TwoFactorEnabled", "UserName", "WorkFrom", "WorkUntil" },
                values: new object[,]
                {
                    { new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), 0, 1, "a23c59ab-fbac-4b83-92f9-2146f6357575", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "employee2@gmail.com", false, "Employee2", 1, true, false, "User2", false, null, "EMPLOYEE2@GMAIL.COM", "EMPLOYEE2", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "50dca28b-72a5-40f7-8954-9edd226388fa", false, "MobileDeliveryPerson2", new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0) },
                    { new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), 0, 1, "00e98254-68ab-4d00-85eb-ed7f4bace3b2", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "flutterhelpme2@gmail.com", false, "Employee", 1, true, false, "User", false, null, "EMPLOYEE@EMPLOYEE.COM", "EMPLOYEE", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "8bebc2d0-e331-427e-88ab-bb9d59040ace", false, "MobileDeliveryPerson", new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0) },
                    { new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), 0, 1, "094dca4e-45c6-49ce-884f-da02c6a1c507", new DateTime(2024, 2, 7, 17, 26, 40, 899, DateTimeKind.Unspecified).AddTicks(9869), "employee1@gmail.com", false, "Employee1", 1, true, false, "User1", false, null, "EMPLOYEE1@GMAIL.COM", "EMPLOYEE1", "AQAAAAIAAYagAAAAEGQ74H878UZXZ2qrO3PGUCmbDkeR0pVC/YQ0BJQHFv50ks5DsM3WDpIZiB85F9hpRg==", "123456789", false, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "cd689d7f-e04d-4dfa-85a1-9050e8f690f7", false, "MobileDeliveryPerson1", new TimeSpan(0, 10, 0, 0, 0), new TimeSpan(0, 18, 0, 0, 0) }
                });

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("7a30f245-f785-466c-a3e6-b1786910007b"), "Hello I have your order here!", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3124), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("90c9ba9a-9187-4fca-9769-583dd7434271"), "Hello your order is right outside!", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3131), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("c6fe80db-91b5-4b1d-b624-f9b9ac0b4766"), "Hello, where is your apartment?", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3137), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.InsertData(
                table: "FoodItemPictures",
                columns: new[] { "Id", "FileName", "FileSize", "FoodItemId" },
                values: new object[,]
                {
                    { 1, "https://localhost:44395/FoodItem_images/hamburger.jpg", 135168, 1 },
                    { 2, "https://localhost:44395/FoodItem_images/cheeseburger.jpg", 57306, 2 },
                    { 3, "https://localhost:44395/FoodItem_images/margarita.jpg", 85319, 3 },
                    { 4, "https://localhost:44395/FoodItem_images/capricoza.jpg", 69759, 4 },
                    { 5, "https://localhost:44395/FoodItem_images/funghi.jpg", 308224, 5 },
                    { 6, "https://localhost:44395/FoodItem_images/fileti.jpg", 59801, 6 },
                    { 7, "https://localhost:44395/FoodItem_images/sausage.jpg", 10547, 7 },
                    { 8, "https://localhost:44395/FoodItem_images/sendvicklasik.jpg", 197632, 8 },
                    { 9, "https://localhost:44395/FoodItem_images/chickensendvic.jpg", 238592, 9 },
                    { 10, "https://localhost:44395/FoodItem_images/pepperoni.jpg", 52838, 10 },
                    { 11, "https://localhost:44395/FoodItem_images/sacher.jpg", 147456, 11 },
                    { 12, "https://localhost:44395/FoodItem_images/baklava.jpg", 64307, 12 },
                    { 13, "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg", 103424, 13 },
                    { 14, "https://localhost:44395/FoodItem_images/dzempalacinke.jpg", 11366, 14 },
                    { 15, "https://localhost:44395/FoodItem_images/margarita.jpg", 85319, 15 },
                    { 16, "https://localhost:44395/FoodItem_images/capricoza.jpg", 69759, 16 },
                    { 17, "https://localhost:44395/FoodItem_images/funghi.jpg", 308224, 17 },
                    { 18, "https://localhost:44395/FoodItem_images/pepperonipizza.jpg", 278528, 18 },
                    { 19, "https://localhost:44395/FoodItem_images/fileti.jpg", 59801, 19 },
                    { 20, "https://localhost:44395/FoodItem_images/cevapi.jpg", 7469, 20 },
                    { 21, "https://localhost:44395/FoodItem_images/cevapi.jpg", 7469, 21 },
                    { 22, "https://localhost:44395/FoodItem_images/greeksalad.jpg", 212992, 22 },
                    { 23, "https://localhost:44395/FoodItem_images/tomatosalad.jpg", 320512, 23 },
                    { 24, "https://localhost:44395/FoodItem_images/regularsalad.jpg", 253952, 24 },
                    { 25, "https://localhost:44395/FoodItem_images/sendvicklasik.jpg", 197632, 25 },
                    { 26, "https://localhost:44395/FoodItem_images/chickensendvic.jpg", 238592, 26 },
                    { 27, "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg", 103424, 27 },
                    { 28, "https://localhost:44395/FoodItem_images/friedsquid.jpg", 354304, 28 },
                    { 29, "https://localhost:44395/FoodItem_images/friedsquid.jpg", 354304, 29 },
                    { 30, "https://localhost:44395/FoodItem_images/pastrmka.jpg", 11572, 30 },
                    { 31, "https://localhost:44395/FoodItem_images/pastrmka.jpg", 11572, 31 },
                    { 32, "https://localhost:44395/FoodItem_images/beefsteak.jpg", 138240, 32 },
                    { 33, "https://localhost:44395/FoodItem_images/chickenskewers.jpg", 149504, 33 },
                    { 34, "https://localhost:44395/FoodItem_images/chickenskewers.jpg", 149504, 34 },
                    { 35, "https://localhost:44395/FoodItem_images/cevapi.jpg", 7469, 35 },
                    { 36, "https://localhost:44395/FoodItem_images/cevapi.jpg", 7469, 36 },
                    { 37, "https://localhost:44395/FoodItem_images/regularsalad.jpg", 253952, 37 },
                    { 38, "https://localhost:44395/FoodItem_images/tomatosalad.jpg", 320512, 38 },
                    { 39, "https://localhost:44395/FoodItem_images/greeksalad.jpg", 212992, 39 },
                    { 40, "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg", 103424, 40 },
                    { 41, "https://localhost:44395/FoodItem_images/baklava.jpg", 64307, 41 },
                    { 42, "https://localhost:44395/FoodItem_images/cevapi.jpg", 7469, 42 },
                    { 43, "https://localhost:44395/FoodItem_images/cevapi.jpg", 7469, 43 },
                    { 44, "https://localhost:44395/FoodItem_images/fileti.jpg", 59801, 44 },
                    { 45, "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg", 103424, 45 },
                    { 46, "https://localhost:44395/FoodItem_images/baklava.jpg", 64307, 46 },
                    { 47, "https://localhost:44395/FoodItem_images/dolma.jpg", 115712, 47 },
                    { 48, "https://localhost:44395/FoodItem_images/japrak.jpg", 83251, 48 },
                    { 49, "https://localhost:44395/FoodItem_images/bibermeso.jpg", 9011, 49 },
                    { 50, "https://localhost:44395/FoodItem_images/bosanskilonac.jpg", 224256, 50 },
                    { 51, "https://localhost:44395/FoodItem_images/hamburger.jpg", 135168, 51 },
                    { 52, "https://localhost:44395/FoodItem_images/cheeseburger.jpg", 57306, 52 },
                    { 53, "https://localhost:44395/FoodItem_images/margarita.jpg", 85319, 53 },
                    { 54, "https://localhost:44395/FoodItem_images/capricoza.jpg", 69759, 54 },
                    { 55, "https://localhost:44395/FoodItem_images/greeksalad.jpg", 212992, 55 },
                    { 56, "https://localhost:44395/FoodItem_images/fileti.jpg", 59801, 56 },
                    { 57, "https://localhost:44395/FoodItem_images/sendvicklasik.jpg", 197632, 57 },
                    { 58, "https://localhost:44395/FoodItem_images/chickensendvic.jpg", 238592, 58 },
                    { 59, "https://localhost:44395/FoodItem_images/baklava.jpg", 64307, 59 },
                    { 60, "https://localhost:44395/FoodItem_images/nutellapalacinke.jpg", 103424, 60 },
                    { 61, "https://localhost:44395/FoodItem_images/dzempalacinke.jpg", 11366, 61 },
                    { 62, "https://localhost:44395/FoodItem_images/margarita.jpg", 85319, 62 },
                    { 63, "https://localhost:44395/FoodItem_images/capricoza.jpg", 69759, 63 },
                    { 64, "https://localhost:44395/FoodItem_images/carbonara.jpg", 129024, 64 },
                    { 65, "https://localhost:44395/FoodItem_images/bolognese.jpg", 70144, 65 },
                    { 66, "https://localhost:44395/FoodItem_images/pesto.jpg", 53760, 66 },
                    { 67, "https://localhost:44395/FoodItem_images/lasagne.jpg", 62976, 67 },
                    { 68, "https://localhost:44395/FoodItem_images/baklava.jpg", 64307, 68 },
                    { 69, "https://localhost:44395/FoodItem_images/dzempalacinke.jpg", 11366, 69 }
                });

            migrationBuilder.InsertData(
                table: "FoodItemSideDishMappings",
                columns: new[] { "FoodItemId", "SideDishId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 4 },
                    { 2, 1 },
                    { 2, 2 },
                    { 2, 4 },
                    { 3, 1 },
                    { 3, 2 },
                    { 3, 5 },
                    { 4, 1 },
                    { 4, 2 },
                    { 4, 5 },
                    { 5, 1 },
                    { 5, 2 },
                    { 5, 5 },
                    { 6, 1 },
                    { 6, 2 },
                    { 6, 4 },
                    { 7, 1 },
                    { 7, 2 },
                    { 7, 4 },
                    { 8, 1 },
                    { 8, 2 },
                    { 8, 3 },
                    { 9, 1 },
                    { 9, 2 },
                    { 9, 3 },
                    { 10, 1 },
                    { 10, 2 },
                    { 10, 3 },
                    { 13, 6 },
                    { 14, 6 },
                    { 15, 7 },
                    { 15, 8 },
                    { 16, 7 },
                    { 16, 8 },
                    { 17, 7 },
                    { 17, 8 },
                    { 18, 7 },
                    { 18, 8 },
                    { 19, 7 },
                    { 19, 8 },
                    { 20, 8 },
                    { 21, 8 },
                    { 25, 7 },
                    { 25, 8 },
                    { 25, 9 },
                    { 26, 7 },
                    { 26, 8 },
                    { 26, 9 },
                    { 27, 10 },
                    { 32, 12 },
                    { 32, 13 },
                    { 32, 15 },
                    { 33, 12 },
                    { 33, 13 },
                    { 34, 12 },
                    { 34, 13 },
                    { 35, 13 },
                    { 35, 14 },
                    { 36, 13 },
                    { 36, 14 },
                    { 37, 16 },
                    { 37, 17 },
                    { 38, 16 },
                    { 38, 17 },
                    { 39, 16 },
                    { 39, 17 },
                    { 42, 20 },
                    { 42, 21 },
                    { 43, 20 },
                    { 43, 21 },
                    { 44, 20 },
                    { 51, 22 },
                    { 51, 23 },
                    { 52, 22 },
                    { 52, 23 },
                    { 53, 22 },
                    { 53, 23 },
                    { 54, 22 },
                    { 54, 23 },
                    { 55, 27 },
                    { 56, 22 },
                    { 56, 23 },
                    { 57, 22 },
                    { 57, 23 },
                    { 57, 24 },
                    { 58, 22 },
                    { 58, 23 },
                    { 58, 24 },
                    { 60, 25 },
                    { 60, 26 },
                    { 61, 25 },
                    { 61, 26 },
                    { 62, 29 },
                    { 62, 30 },
                    { 63, 29 },
                    { 63, 30 },
                    { 67, 31 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "CreatedByUserId", "CreatedDate", "IsDeleted", "ModifiedByUserId", "Path", "UserProfilePictureId" },
                values: new object[,]
                {
                    { 7, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7739), false, null, "/Uploads/Images/9c3affff-791b-4680-8168-13d0b632cf8e.jpg", new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") },
                    { 8, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7743), false, null, "/Uploads/Images/ed3a87b4-3710-4484-893d-ae4751014dab.jpg", new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760") },
                    { 9, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7746), false, null, "/Uploads/Images/employee4.jpg", new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43") }
                });

            migrationBuilder.InsertData(
                table: "Notifications",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "RestaurantName", "SentByUserId", "SentToUserId" },
                values: new object[,]
                {
                    { 1, "Your order has been delivered.", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3158), false, "Aldi - Caffe slastičarna", new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { 2, "Your order has been delivered.", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3163), false, "Aldi - Caffe slastičarna", new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { 3, "Your order has been delivered.", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3166), false, "Aldi - Caffe slastičarna", new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { 4, "You have been assigned to an order.", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3168), false, "Aldi - Caffe slastičarna", new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"), new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Cost", "FoodItemId", "OrderId", "Quantity", "SideDishIds" },
                values: new object[,]
                {
                    { 1, 20.0, 1, new Guid("faf51d20-4224-4894-940e-1d916274b611"), 2, "" },
                    { 2, 20.0, 3, new Guid("faf51d20-4224-4894-940e-1d916274b611"), 2, "" },
                    { 4, 10.0, 4, new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"), 1, "" },
                    { 5, 10.0, 4, new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"), 2, "" },
                    { 7, 10.0, 7, new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"), 1, "" },
                    { 8, 10.0, 8, new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"), 1, "" },
                    { 10, 10.0, 10, new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"), 1, "" },
                    { 11, 10.0, 11, new Guid("ff454850-5665-4246-aa6f-738cb80aa325"), 2, "" },
                    { 12, 30.0, 15, new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"), 2, "" },
                    { 13, 30.0, 16, new Guid("5fd9e288-163c-4286-bb40-02213f53198f"), 2, "" },
                    { 14, 15.0, 29, new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"), 2, "" },
                    { 15, 15.0, 31, new Guid("650327a7-1218-4306-aca5-cb30ef57de36"), 2, "" },
                    { 16, 15.0, 44, new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"), 2, "" },
                    { 17, 15.0, 45, new Guid("0167003f-76d8-4736-9010-9f4f756c5107"), 2, "" },
                    { 18, 8.0, 57, new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"), 1, "" },
                    { 19, 10.0, 58, new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"), 2, "" },
                    { 20, 4.0, 67, new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"), 1, "" },
                    { 21, 14.0, 68, new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"), 2, "" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "Allergies", "CreatedByUserId", "CreatedDate", "DeliveryPersonAssignedId", "IsDeleted", "IsPaid", "LocationId", "OrderState", "PaymentMethod", "RestaurantId", "TotalCost" },
                values: new object[,]
                {
                    { new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"), "123 Main St", "Some nuts", new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2207), new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), false, true, 8, 2, 2, 1, 40.0 },
                    { new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"), "123 Main St", "Some nuts", new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2215), new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), false, true, 10, 2, 2, 1, 35.0 },
                    { new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"), "123 Main St", "Some berries", new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"), new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2222), new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), false, true, 12, 2, 2, 1, 27.0 }
                });

            migrationBuilder.InsertData(
                schema: "identity",
                table: "asp_net_user_roles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"), new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43") },
                    { new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"), new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") },
                    { new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"), new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760") }
                });

            migrationBuilder.InsertData(
                table: "OrderItemSideDish",
                columns: new[] { "OrderItemId", "SideDishId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 4, 1 },
                    { 5, 2 },
                    { 7, 4 },
                    { 8, 2 },
                    { 10, 1 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "Id", "Cost", "FoodItemId", "OrderId", "Quantity", "SideDishIds" },
                values: new object[,]
                {
                    { 3, 10.0, 4, new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"), 1, "" },
                    { 6, 10.0, 6, new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"), 1, "" },
                    { 9, 10.0, 9, new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"), 1, "" }
                });

            migrationBuilder.InsertData(
                table: "OrderItemSideDish",
                columns: new[] { "OrderItemId", "SideDishId" },
                values: new object[,]
                {
                    { 3, 1 },
                    { 6, 4 },
                    { 9, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_role_claims_RoleId",
                schema: "identity",
                table: "asp_net_role_claims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                schema: "identity",
                table: "asp_net_roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_user_claims_UserId",
                schema: "identity",
                table: "asp_net_user_claims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_user_logins_UserId",
                schema: "identity",
                table: "asp_net_user_logins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_user_roles_RoleId",
                schema: "identity",
                table: "asp_net_user_roles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                schema: "identity",
                table: "asp_net_users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_users_CityId",
                schema: "identity",
                table: "asp_net_users",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_users_RestaurantId",
                schema: "identity",
                table: "asp_net_users",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                schema: "identity",
                table: "asp_net_users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserFromId",
                table: "Chats",
                column: "UserFromId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_UserToId",
                table: "Chats",
                column: "UserToId");

            migrationBuilder.CreateIndex(
                name: "IX_Emails_UserId",
                table: "Emails",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemPictures_FoodItemId",
                table: "FoodItemPictures",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_CategoryId",
                table: "FoodItems",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_CreatedByUserId",
                table: "FoodItems",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_ModifiedByUserId",
                table: "FoodItems",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_RestaurantId",
                table: "FoodItems",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemSideDishMappings_SideDishId",
                table: "FoodItemSideDishMappings",
                column: "SideDishId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CreatedByUserId",
                table: "Images",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ModifiedByUserId",
                table: "Images",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserProfilePictureId",
                table: "Images",
                column: "UserProfilePictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityId",
                table: "Locations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CreatedByUserId",
                table: "Locations",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Locations_ModifiedByUserId",
                table: "Locations",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_SentByUserId",
                table: "Notifications",
                column: "SentByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_SentToUserId",
                table: "Notifications",
                column: "SentToUserId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_FoodItemId",
                table: "OrderItems",
                column: "FoodItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemSideDish_SideDishId",
                table: "OrderItemSideDish",
                column: "SideDishId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CreatedByUserId",
                table: "Orders",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DeliveryPersonAssignedId",
                table: "Orders",
                column: "DeliveryPersonAssignedId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_LocationId",
                table: "Orders",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_RestaurantId",
                table: "Orders",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CreatedByUserId",
                table: "Restaurants",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_LocationId",
                table: "Restaurants",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_LogoId",
                table: "Restaurants",
                column: "LogoId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_ModifiedByUserId",
                table: "Restaurants",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_CreatedByUserId",
                table: "Reviews",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ModifiedByUserId",
                table: "Reviews",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_RestaurantId",
                table: "Reviews",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_SideDishes_RestaurantId",
                table: "SideDishes",
                column: "RestaurantId");

            migrationBuilder.CreateIndex(
                name: "IX_Verifications_UserId",
                table: "Verifications",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_asp_net_user_claims_asp_net_users_UserId",
                schema: "identity",
                table: "asp_net_user_claims",
                column: "UserId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_net_user_logins_asp_net_users_UserId",
                schema: "identity",
                table: "asp_net_user_logins",
                column: "UserId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_net_user_roles_asp_net_users_UserId",
                schema: "identity",
                table: "asp_net_user_roles",
                column: "UserId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_net_user_tokens_asp_net_users_UserId",
                schema: "identity",
                table: "asp_net_user_tokens",
                column: "UserId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_asp_net_users_Restaurants_RestaurantId",
                schema: "identity",
                table: "asp_net_users",
                column: "RestaurantId",
                principalTable: "Restaurants",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_asp_net_users_CreatedByUserId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_asp_net_users_ModifiedByUserId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Images_asp_net_users_UserProfilePictureId",
                table: "Images");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_asp_net_users_CreatedByUserId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Locations_asp_net_users_ModifiedByUserId",
                table: "Locations");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_asp_net_users_CreatedByUserId",
                table: "Restaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_asp_net_users_ModifiedByUserId",
                table: "Restaurants");

            migrationBuilder.DropTable(
                name: "asp_net_role_claims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "asp_net_user_claims",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "asp_net_user_logins",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "asp_net_user_roles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "asp_net_user_tokens",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Chats");

            migrationBuilder.DropTable(
                name: "Emails");

            migrationBuilder.DropTable(
                name: "FoodItemPictures");

            migrationBuilder.DropTable(
                name: "FoodItemSideDishMappings");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "OrderItemSideDish");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Verifications");

            migrationBuilder.DropTable(
                name: "asp_net_roles",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "SideDishes");

            migrationBuilder.DropTable(
                name: "FoodItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "asp_net_users",
                schema: "identity");

            migrationBuilder.DropTable(
                name: "Restaurants");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Locations");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
