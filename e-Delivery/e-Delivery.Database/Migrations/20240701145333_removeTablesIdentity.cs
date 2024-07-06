using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class removeTablesIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                name: "asp_net_user_tokens",
                schema: "identity");

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("67d91632-def7-4165-b218-9e235c2af588"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("88594f69-fd4b-4ab2-81f9-febe80aa9ca4"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("a7554815-cb48-425c-9a9e-6b825a438d34"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("26d48e99-c21a-43d2-9cae-1350fed898f6"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("3f00dda0-95c7-4b80-a94c-3d9902eccb05"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("e2df18cf-0937-45e1-bd3c-1a265e477148"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1742));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1744));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("0ed400c1-eb1e-4f46-bb50-7e664cb04583"), "Hello your order is right outside!", new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3844), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("9b4ad045-8770-4eaa-accc-9be8749c16d0"), "Hello, where is your apartment?", new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3847), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("ede96779-b700-459b-a47e-8f7243c825fa"), "Hello I have your order here!", new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3839), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1871));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1889));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1892));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1952));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1956));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1957));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1961));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1963));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2777));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2780));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2825));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2837));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2843));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2846));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2855));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2864));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2868));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2871));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2877));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2903));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2906));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2923));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3011));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3014));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3019));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3025));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3034));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3037));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3043));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3052));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2614));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2649));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2498));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2523));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3875));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3883));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3442));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3523));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3506));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3511));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3513));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3448));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3424));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(2700));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3744));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3754));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3762));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3768));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3788));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 1, 16, 53, 32, 638, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.InsertData(
                table: "Verifications",
                columns: new[] { "Id", "Code", "ExpireDate", "IsConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("19c8cdd1-1bf5-46eb-aa7c-6db46e24c1d7"), "c7b3f0", new DateTime(2024, 7, 1, 17, 23, 32, 638, DateTimeKind.Local).AddTicks(3936), false, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("df1304e2-be49-4064-92ce-004f26223ce7"), "41d0e5", new DateTime(2024, 7, 1, 17, 23, 32, 638, DateTimeKind.Local).AddTicks(3933), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") },
                    { new Guid("e2245478-d88d-41e4-9458-16d160f6e3a9"), "8a2f9b", new DateTime(2024, 7, 1, 17, 23, 32, 638, DateTimeKind.Local).AddTicks(3928), false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b") }
                });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "1b48e1d3-b8ee-4f43-b72a-9aaba3d98e19");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "e4327e16-f1b4-4984-ac50-3d387426e53c");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "afc76822-c65e-46db-ad2a-1ab749e50809");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "791a782f-ac19-419c-9ef7-950eaef73513");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9fecc9d4-8fb9-460c-88de-eb6fce8dab72", "4334ab79-d561-40f8-b0c0-7925dd669183" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e108f0f-0d0b-48a7-8a16-5d31b2c59969", "f9898003-abc6-4011-bfba-2e36dedddcb8" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "732dd1a4-ffb9-4eb4-a8b6-26fa608a10d5", "0487b4e7-9873-4c94-be23-22ee1efd6ea5" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "36190b51-9a78-41bc-bda7-dc67531adedb", "d99c742f-0a6a-4ac1-9987-bed6226e156b" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b052163c-af38-4e56-a0b5-266eff8f7db2", "2f77da45-34d4-41aa-ba51-6eff4fddc93c" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "545742b6-b093-4a36-a494-20fe7c20ce8b", "f06cd6b2-9713-4999-a97a-3f930f362cef" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "59098f6e-c0d6-4204-a38c-fd81316f9bc4", "6205f0d4-b529-4214-a3b1-3f5e7569e3ff" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c4523d0f-c902-449f-a482-bce4e966923d", "52db9fa9-57e0-4ed4-8419-7a15cd3b317e" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cc677d11-0625-4536-9488-9fbfad888d8b", "bd71cdfa-fc2e-4542-a13b-c8155556b4c8" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "de073909-7537-4b25-ba6b-6723701016dd", "b157428d-dcc4-4dc3-b0eb-346d6a305f66" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b613605a-247f-4cc4-a146-2a4fe9114f6c", "3e6f7b0a-5942-4ce4-9886-d364a6cdee9c" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d2aa9646-4962-4d69-be3f-7ac66648f606", "7f9836e1-39fa-4549-818e-1f81c3a039ce" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15752a17-5f23-4ed9-b00d-b3d17f5be749", "e03e5eaa-b027-4bcd-abbf-3b1a3609790c" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6a7d3fb7-a643-4162-b2b0-dcb8c1381074", "0763d208-a3a2-45c2-a4d9-a9e3651859e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("0ed400c1-eb1e-4f46-bb50-7e664cb04583"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9b4ad045-8770-4eaa-accc-9be8749c16d0"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("ede96779-b700-459b-a47e-8f7243c825fa"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("19c8cdd1-1bf5-46eb-aa7c-6db46e24c1d7"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("df1304e2-be49-4064-92ce-004f26223ce7"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("e2245478-d88d-41e4-9458-16d160f6e3a9"));

            migrationBuilder.CreateTable(
                name: "asp_net_role_claims",
                schema: "identity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
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
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asp_net_user_claims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_asp_net_user_claims_asp_net_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    table.ForeignKey(
                        name: "FK_asp_net_user_logins_asp_net_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
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
                    table.ForeignKey(
                        name: "FK_asp_net_user_tokens_asp_net_users_UserId",
                        column: x => x.UserId,
                        principalSchema: "identity",
                        principalTable: "asp_net_users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1683));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1717));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1730));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("67d91632-def7-4165-b218-9e235c2af588"), "Hello I have your order here!", new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3507), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("88594f69-fd4b-4ab2-81f9-febe80aa9ca4"), "Hello your order is right outside!", new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3511), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("a7554815-cb48-425c-9a9e-6b825a438d34"), "Hello, where is your apartment?", new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3514), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1824));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1828));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1836));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1840));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1841));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1846));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1849));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1850));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1861));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2620));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2667));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2680));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2683));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2698));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2768));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2775));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2778));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2781));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2784));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2796));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2802));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2808));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2811));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2818));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2821));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2829));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2844));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2911));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2914));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2483));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2489));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2499));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2335));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2347));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2394));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2411));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2417));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2420));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2423));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2443));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3576));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3585));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3261));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3273));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3302));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3278));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3296));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3265));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2538));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3457));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3466));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 25, 23, 43, 35, 382, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.InsertData(
                table: "Verifications",
                columns: new[] { "Id", "Code", "ExpireDate", "IsConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("26d48e99-c21a-43d2-9cae-1350fed898f6"), "c7b3f0", new DateTime(2024, 6, 26, 0, 13, 35, 382, DateTimeKind.Local).AddTicks(3636), false, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("3f00dda0-95c7-4b80-a94c-3d9902eccb05"), "41d0e5", new DateTime(2024, 6, 26, 0, 13, 35, 382, DateTimeKind.Local).AddTicks(3633), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") },
                    { new Guid("e2df18cf-0937-45e1-bd3c-1a265e477148"), "8a2f9b", new DateTime(2024, 6, 26, 0, 13, 35, 382, DateTimeKind.Local).AddTicks(3628), false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b") }
                });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "78a5b1ba-adc0-480a-a587-6a633fdbd359");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "55f148fa-5c05-4ef0-8175-927f7b940da5");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "bad4f424-62f8-4715-a57e-102979a7b74d");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "e6eecae8-29d2-4b59-818e-2d61c584e10b");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e28ab25c-9e22-48e8-af65-d8242976c7be", "5adc259c-01cd-4c74-80ff-e23d4b348a6e" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2f608402-bc3b-42bf-84a0-64a1b8d7e10a", "5d7dfe99-8853-430b-9a3b-6f0355465aa1" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b056291b-bd70-4a42-95b7-8c28146f40b7", "94227af4-3310-4431-a0de-d3f4354982cb" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a9f5730c-32d5-4563-a913-699f24da957c", "f59d8ced-0160-4ea7-bb4c-e1fa90f12212" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3bc8019c-8986-42d4-a8d4-783c894419ee", "d78744be-08f6-4faf-b013-e01d272845ad" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d0ca1492-ccd6-4726-ae86-8c2c1a1cc1c4", "5ee35095-9df4-4026-9f23-5066ba8b4e74" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "be7f2d62-c1ab-48cf-834e-5b368fb774bc", "4adb7343-acfe-4593-9924-154a6bbe5944" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "74d2f849-5781-4bdf-a7f3-474cc9886e82", "ac748a48-0772-465a-b016-d88cd18a0272" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7da4b84-83d0-41d9-8969-1aaf756b4d09", "e5b40db7-ef0a-44da-a9bc-92503893ec30" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "43202e1e-92d4-4810-b2ae-b6519553c254", "9d798ce3-5cba-443c-9581-6483d93b5e56" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "2aedc418-7aa9-45ef-a552-31e4efa65266", "6fad7535-6f6a-4a43-af16-0b365438c0a4" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b85909c8-2d5d-4366-88a3-b3a52db054ca", "1be845b3-e2c3-47be-8aa6-2d8eeef205b3" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a009be63-5c2a-4a9d-beea-491fbb79b4c4", "63d94899-742c-4679-9705-3b933e8c54a5" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e2b2d15b-131d-4cc9-857a-2e64b0d07142", "598e8baf-2a31-46d3-ba28-115bc517064c" });

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_role_claims_RoleId",
                schema: "identity",
                table: "asp_net_role_claims",
                column: "RoleId");

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
        }
    }
}
