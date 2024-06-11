using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("7a30f245-f785-466c-a3e6-b1786910007b"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("90c9ba9a-9187-4fca-9769-583dd7434271"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("c6fe80db-91b5-4b1d-b624-f9b9ac0b4766"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1420));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1454));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1456));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1460));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1462));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1463));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("65cde832-f7cd-445b-85a4-1216ad31efe8"), "Hello your order is right outside!", new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3130), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("840e162e-4cad-4c3b-ae4a-338e973bcc7f"), "Hello, where is your apartment?", new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3136), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("a7387e77-1ca2-470c-96bb-da318ef445bc"), "Hello I have your order here!", new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3125), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1526));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1531));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1540));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1550));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1554));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1572));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1575));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2258));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2261));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2264));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2267));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2286));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2293));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2302));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2305));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2366));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2379));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2382));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2388));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2390));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2400));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2409));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2415));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2421));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2424));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2437));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2449));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2452));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2493));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2503));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2534));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2544));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2547));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2048));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2063));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2068));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2070));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2075));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2080));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2089));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3154));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3162));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3164));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2931));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2857));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2863));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2861));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2937));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2876));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2929));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2866));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2870));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2848));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2924));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2211));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2216));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2221));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2224));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3059));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3072));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3078));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3084));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3087));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3096));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 16, 17, 50, 956, DateTimeKind.Local).AddTicks(3101));

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "f0df392e-b4b4-4357-9d34-299170dd0af8");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "65f10588-f588-4d9a-9350-3496426dfdc1");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "e9be671c-72dc-4fe9-a0f4-bda20301b68b");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "a0ec5c5c-ae88-47fe-b42f-2461f873377d");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5f11f6c2-2106-4f69-b7ea-6b2d1f73d64b", "764cfb95-f4c0-4cac-88c1-e4c4efc4f334" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38b38731-4f59-4c72-9972-e3cbfbae3c02", "4be1d8f3-ed49-4bf8-ad6a-ce082cb2ef57" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c32a2709-21d0-4058-97d7-1f6745f6181c", "92cf3498-3904-4abb-82f3-f0320098376d" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c56dd1e8-299d-403f-a02b-67e00a63e624", "be3d1ca4-7751-4ec1-996e-2b45c08bd683" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "762817bf-98f4-478f-9ba1-34619e50ef90", 4, "39371a1e-e1c9-43ad-9498-6beccda33e71" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "e70e3ab6-5fce-479d-983a-27dad017013f", 5, "eed6a0f5-0255-4fb0-99a4-27bb72dbb36e" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "506abe73-5d78-440b-8d18-f49bc983560b", 3, "354d040b-e3ab-4c8b-a08d-c60f4fd03d44" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "42f893a0-5839-4bf6-8c82-21f76fd8dba7", "e7adbf12-ad65-4587-8801-7fc78e13d88f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd35d054-fa5b-4718-a771-f97e31de7b25", "f07beebb-f54b-4d3e-9113-9b0000ec41d7" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "55fa3c9b-da27-4060-bd62-1593243e99cf", "db84a8e1-e05f-4754-abc0-9b5e89270968" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "534a7d71-bae4-4a90-9f04-bf683010eb13", 2, "bdf81a3b-65ec-4aea-b8b5-71e11efbe872" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6001bc37-4b78-4dea-a710-f3e9680cfc0a", "c706ef59-a604-418f-a2db-63d108e66c91" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "cfa4f0f8-3301-4a95-8615-2d3d24915574", 6, "39f7b6ac-6404-43e0-a0b4-d016060259f8" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "bcec5696-6c85-4a83-9ff3-b6fe7164669e", 1, "8bc507ec-7d44-4440-9c41-34e05b7b2ba9" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("65cde832-f7cd-445b-85a4-1216ad31efe8"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("840e162e-4cad-4c3b-ae4a-338e973bcc7f"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("a7387e77-1ca2-470c-96bb-da318ef445bc"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6983));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6985));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6986));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(6990));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("7a30f245-f785-466c-a3e6-b1786910007b"), "Hello I have your order here!", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3124), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("90c9ba9a-9187-4fca-9769-583dd7434271"), "Hello your order is right outside!", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3131), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("c6fe80db-91b5-4b1d-b624-f9b9ac0b4766"), "Hello, where is your apartment?", new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3137), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7117));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7129));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7139));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7142));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7873));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7880));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7887));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7890));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7893));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7903));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7906));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1521));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1551));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1555));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1569));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1573));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1579));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1583));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1633));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1642));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1646));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1652));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1655));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1659));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1662));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1665));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1669));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1671));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1675));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1678));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1682));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1693));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1707));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1710));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1726));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1759));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1772));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1776));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7723));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7729));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7734));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7737));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7743));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7746));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7749));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7755));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7643));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7651));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7665));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7669));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7672));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7679));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7681));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7683));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7692));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7694));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7696));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3158));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3168));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2253));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2215));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2212));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2238));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2225));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2260));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2256));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2232));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2229));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2247));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2250));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2222));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2244));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7778));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7813));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7824));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 47, DateTimeKind.Local).AddTicks(7828));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2399));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2403));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2406));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2413));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(2416));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3002));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3009));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3055));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 15, 42, 49, 48, DateTimeKind.Local).AddTicks(3058));

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "4b7b90a8-799b-4d5c-9c9e-11ee630a7d48");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "ef4d26e8-df82-42ef-aeaa-7a4b2c9975ea");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "d9d6c9c7-9c6b-47da-badf-19cb447a908e");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "b5e09401-bbbe-4ab7-b6f0-f9b03a462ad0");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a23c59ab-fbac-4b83-92f9-2146f6357575", "50dca28b-72a5-40f7-8954-9edd226388fa" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b8c107a8-06be-416a-9ddb-a020464ae1f3", "805f80e9-8118-48bc-8677-f5ac1625de74" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b4ac1b1b-4c17-4af0-8b1f-f822ca7809ea", "726897f4-76fe-4e7f-bcd6-890753ead106" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b3f1dadd-c6bc-4f2f-a56c-41e2ed79fd48", "b497d406-5453-438e-9bd4-71177d6ca9b8" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "c97e47b7-e862-4930-abab-39859961a1cf", null, "878ff0d8-bc79-49fa-b9a5-a862541efb9e" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "219c6691-86e9-437b-9bf8-c1ef24babdd3", null, "bbf2fef1-693a-4926-8057-228dc4fe314b" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "64494c1f-d7b6-4670-a638-c4383a71dec1", null, "02df7035-72bf-4e81-ac4c-8ccedb195ccc" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "00e98254-68ab-4d00-85eb-ed7f4bace3b2", "8bebc2d0-e331-427e-88ab-bb9d59040ace" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "094dca4e-45c6-49ce-884f-da02c6a1c507", "cd689d7f-e04d-4dfa-85a1-9050e8f690f7" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a706e15e-04ab-47bf-8d53-7d29e147c8a5", "cf0c17c1-7f70-4de8-9dc6-24c25334c1a2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "ba1954c0-c343-4028-bd5c-39857b24728b", null, "a37dc3d1-2722-4900-a15d-99ac6f9ffb95" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "5cc55d81-94e0-4c30-8648-afaebb1cf7ff", "5fb231ab-6419-4e2f-bc7a-471df74819dd" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "c0e32b0c-97f0-42ca-9ca6-a88d5d9dcd92", null, "0231e462-3830-4bfd-b664-17852d6c3357" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "RestaurantId", "SecurityStamp" },
                values: new object[] { "1547feec-6731-459e-8edf-39f5d798b878", null, "8673c57f-d8ce-4c30-a4b2-87048729bf1b" });
        }
    }
}
