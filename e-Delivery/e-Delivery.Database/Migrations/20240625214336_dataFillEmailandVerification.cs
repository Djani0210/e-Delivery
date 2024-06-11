using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class dataFillEmailandVerification : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("873ebb20-6fd9-499d-8393-68c6994b0280"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("9744f78a-1367-47ae-ad29-2417dc51ddb9"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("a59df349-8d48-4c04-a064-df54449b0a6c"));

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

            migrationBuilder.InsertData(
                table: "Emails",
                columns: new[] { "Id", "Content", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, "Verification code", "8a2f9b", new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b") },
                    { 2, "Verification code", "41d0e5", new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") },
                    { 3, "Verification code", "c7b3f0", new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Emails",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Emails",
                keyColumn: "Id",
                keyValue: 3);

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
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(773));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("873ebb20-6fd9-499d-8393-68c6994b0280"), "Hello your order is right outside!", new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2708), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("9744f78a-1367-47ae-ad29-2417dc51ddb9"), "Hello, where is your apartment?", new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2711), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("a59df349-8d48-4c04-a064-df54449b0a6c"), "Hello I have your order here!", new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2702), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1001));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1014));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1017));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1019));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1020));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1022));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1027));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1028));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1030));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1038));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1040));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1044));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1786));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1833));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1835));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1839));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1845));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1858));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1862));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1903));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1906));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1910));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1922));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1965));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1968));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1971));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1978));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1981));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1984));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1989));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2007));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2010));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2023));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2026));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2035));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2046));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2052));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1653));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1658));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1661));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1666));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1677));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1680));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1535));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1552));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1608));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1612));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1615));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1617));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1619));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1621));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2432));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2482));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2456));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2445));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2419));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2468));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2663));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 24, 19, 1, 47, 489, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "dc4e9877-f568-4801-9254-7bc61d0023e8");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "06f2485a-f17d-48d4-8c5e-52b02011e678");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "4cd76590-7f78-4bee-b8d7-7a0e3b4065ea");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "f8cc8bd4-8d33-47e9-abff-033f4360a0b8");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ec6164d-0cdc-4412-aadc-76fa4ee5b36b", "4f4b9aba-42b4-45ec-ae17-7e849a161805" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a17ae61b-846c-4700-bcd1-99e41abe6bee", "51f51594-ee1a-4cd4-aedf-4a9a3bbb8e19" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e66e3ad3-61ab-4d04-9138-7465b82165e7", "3eba2d9c-a19a-4307-bdbf-8052cc8d2ca6" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b88cdd7d-dc58-4140-9159-373b962f4a59", "fe64bf0b-165a-48da-af11-d55577fdc2fa" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6cdb5e0e-993b-4b79-b57d-0523407af4f3", "21478257-b59a-4334-b776-f8f56679c4f2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f1e999e2-ed3c-414f-8e19-c0336c520b01", "f228f7ef-d96c-40cb-9690-85cded12335b" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c06e9db2-c9d3-4822-bbdc-6aaeb6c11ed5", "2f0402e1-2b28-48f0-9da0-8e92fc8ffe86" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "94c67611-6f65-4f1a-8fd7-273edab9da23", "4101caae-b5bc-4894-bebf-49256a40d360" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8e49a13e-e0aa-4e46-b1d0-db25c195d3a7", "beec0055-155b-4d0b-9e44-cd2828a8be55" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e9574119-174b-43f4-aad2-2fae993094b6", "040d48f2-5a2c-4181-97c7-0789b8aa01dd" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "66a39206-4543-4327-b990-f6a04585f5ee", "27162c42-de11-4a95-8f60-1a5b65cb35dd" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e5bb61cc-ed03-43ad-835b-836a6fb2c1aa", "da7c77a5-2950-4365-acd4-6f3a9a2b9e4b" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4225f667-5cb2-42d2-b8d5-126c22e96f53", "99c4991d-331c-4dc5-aea8-fe1b89c2d61d" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7ebe553a-bff6-4a9d-b7f6-86726fa8d150", "825a3f11-b2af-4765-bc42-367dc0446a69" });
        }
    }
}
