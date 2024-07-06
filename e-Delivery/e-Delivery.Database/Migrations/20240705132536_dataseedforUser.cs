using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class dataseedforUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("7ced344b-6d5f-4d21-a8e9-b7915ee22a6a"), "Hello, where is your apartment?", new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8609), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("8c20b6d1-a35f-4521-b90d-2d32b07762b4"), "Hello your order is right outside!", new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8606), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("c9f8a2b6-179d-4e8a-9d29-62c763473eb8"), "Hello I have your order here!", new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8601), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6556));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6564));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6565));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6567));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6568));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6572));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6573));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6576));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6585));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6588));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6591));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6593));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6596));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6599));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6602));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7357));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7363));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7403));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7408));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7412));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7414));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7421));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7424));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7430));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7436));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7440));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7443));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7446));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7449));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7452));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7456));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7459));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7464));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7474));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7478));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7481));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7486));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7493));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7538));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7541));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7544));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7557));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7563));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7565));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7568));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7571));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7583));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7586));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7589));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7594));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7606));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7239));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7245));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7251));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7254));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7256));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7263));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7269));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7271));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7087));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7106));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7179));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7182));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7185));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7187));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7192));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7204));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7206));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7210));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8635));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7293));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7300));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7306));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7309));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(7313));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8538));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8546));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8552));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8557));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8564));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 5, 15, 25, 35, 699, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.InsertData(
                table: "Verifications",
                columns: new[] { "Id", "Code", "ExpireDate", "IsConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("65e15d06-54dd-443b-988e-6d304d25f324"), "41d0e5", new DateTime(2024, 7, 5, 15, 55, 35, 699, DateTimeKind.Local).AddTicks(8764), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") },
                    { new Guid("9ffe782d-95f1-4ce0-bea7-26695d8fafd0"), "8a2f9b", new DateTime(2024, 7, 5, 15, 55, 35, 699, DateTimeKind.Local).AddTicks(8757), false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b") },
                    { new Guid("c08fee47-4046-413b-9d4a-997f2df7df8b"), "c7b3f0", new DateTime(2024, 7, 5, 15, 55, 35, 699, DateTimeKind.Local).AddTicks(8772), false, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "40b45415-919c-472d-b993-ebe6b69c58d4");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "c2977abc-7cc3-46c9-8ce1-17cb281a8934");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "79f011a7-5990-4cde-b1bf-8b37491010c9");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "ecc4dbec-6b61-4d51-8883-606aae3247c3");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "b87a2624-b142-487a-b2b4-0ab44a60a383", "2b2e81e7-032d-4c82-bc23-b35b9b5a25e2", "DeliveryPerson2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "e9783d51-8dd3-425c-a49a-d5ef0b67f555", "0408ee68-cacc-4562-bf96-49f5326dfb73", "Customer1" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f9499d0a-d0ee-4579-8ee2-a5c65aa62bd2", "a0f3ca11-fa59-44bd-913e-cecd9bec5bd7" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "b7462d22-b28a-4c38-8e42-68635c2d8723", "9ee159ff-aa00-44c2-a8f7-901a63b5fea4", "Customer2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "58e0e6b8-a23a-439c-8c15-ab431f01b2ba", "3d264d91-9178-4201-903c-44a96a9ac9ff" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "67e95be6-a9e9-47d6-9c54-069c9c352dcf", "4fe82d94-87db-483a-86bf-564c189b5bd4" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15eb0a05-0fda-4c1f-94fd-32be9f0e74bf", "118e83d3-1d09-4c6b-9b02-db9cc473d5ae" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "40fc4cd4-708f-47f1-93de-ccd926a95587", "a4925315-0e97-46c3-aea4-fc6f6b44b9d7", "DeliveryPerson" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "f22060ed-dc00-456f-99c4-e95f8b81d976", "87adfed2-f8fa-4996-aa14-c0c9e19ceae5", "DeliveryPerson1" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "9095478e-76b3-41fe-a3a4-6f95cd69ed5a", "63fa6898-eb4c-44e6-860b-83e3d53a8c64", "Customer" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "cfb21be2-4214-41bf-a6d0-9fb005b2d156", "e7e4b2a4-c1e9-48fd-bc69-9e5d3357846c" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "441e4e1b-f803-4cdf-8c35-ac32cce58048", "ef14e78c-2061-4e25-997f-40ebdcd826c3" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "87304225-959c-4c16-9c59-fba902b16b79", "6cacf782-000d-496e-9e2c-a6bf64f297fc" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4da0efad-3f20-4269-9cb0-8a0367cdab9b", "3786f9b6-63ea-4472-88f8-48b5984bf437" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("7ced344b-6d5f-4d21-a8e9-b7915ee22a6a"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("8c20b6d1-a35f-4521-b90d-2d32b07762b4"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("c9f8a2b6-179d-4e8a-9d29-62c763473eb8"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("65e15d06-54dd-443b-988e-6d304d25f324"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("9ffe782d-95f1-4ce0-bea7-26695d8fafd0"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("c08fee47-4046-413b-9d4a-997f2df7df8b"));

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "9fecc9d4-8fb9-460c-88de-eb6fce8dab72", "4334ab79-d561-40f8-b0c0-7925dd669183", "MobileDeliveryPerson2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "8e108f0f-0d0b-48a7-8a16-5d31b2c59969", "f9898003-abc6-4011-bfba-2e36dedddcb8", "MobileCustomer1" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "36190b51-9a78-41bc-bda7-dc67531adedb", "d99c742f-0a6a-4ac1-9987-bed6226e156b", "MobileCustomer2" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "c4523d0f-c902-449f-a482-bce4e966923d", "52db9fa9-57e0-4ed4-8419-7a15cd3b317e", "MobileDeliveryPerson" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "cc677d11-0625-4536-9488-9fbfad888d8b", "bd71cdfa-fc2e-4542-a13b-c8155556b4c8", "MobileDeliveryPerson1" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp", "UserName" },
                values: new object[] { "de073909-7537-4b25-ba6b-6723701016dd", "b157428d-dcc4-4dc3-b0eb-346d6a305f66", "MobileCustomer" });

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
    }
}
