using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class removeGenderColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("5a2a9e01-9738-4449-8937-3e317d5f164d"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("71554735-3924-4480-8865-457f196d8e15"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("961fe50f-0657-44fa-8493-99bf77c18396"));

            migrationBuilder.DropColumn(
                name: "Gender",
                schema: "identity",
                table: "asp_net_users");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                schema: "identity",
                table: "asp_net_users",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5486));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5520));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5527));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5528));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5530));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5532));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5533));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("5a2a9e01-9738-4449-8937-3e317d5f164d"), "Hello your order is right outside!", new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7195), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("71554735-3924-4480-8865-457f196d8e15"), "Hello, where is your apartment?", new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7198), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("961fe50f-0657-44fa-8493-99bf77c18396"), "Hello I have your order here!", new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7190), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5620));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5624));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5625));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5627));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5629));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5631));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5632));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5634));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5642));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5648));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5661));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6333));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6337));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6340));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6355));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6451));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6473));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6476));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6480));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6483));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6486));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6492));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6495));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6498));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6504));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6506));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6527));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6530));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6563));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6566));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6569));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6575));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6578));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6581));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6584));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6587));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6590));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6600));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6603));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6213));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6145));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6148));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6157));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6159));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6161));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6163));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6166));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6171));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6178));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7217));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7220));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6945));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6976));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6967));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7096));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7161));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7163));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 11, 17, 12, 56, 593, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "662929e8-894a-4209-b5d1-9c502c8e3b87");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "76448cd7-5d5d-40b8-8e2d-1b013777dfba");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "ac1f8291-9c6b-4cf1-9a78-e59ba32ee4b1");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "0f7da838-ce7b-44f5-aed7-952e4dde2392");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "112c85e3-0cad-44de-a19f-f4d724a8508d", 1, "e81e235f-ebdb-4564-96ae-765b3090119f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "09ee00e3-c4c5-4a59-b1c8-b115c4894bf6", 1, "5c9cd85e-52af-49aa-abbd-d69da2d9f8ea" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "323771ac-c745-41ce-8d35-b820846724be", 1, "51f7aaa4-df70-4b66-ada2-ba558338c14f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "f8e8281a-7201-48de-9de4-5b1d9893a890", 1, "f8b92d8b-4747-48c1-a1a7-098fda34993d" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "81f474df-2af7-46ec-9c8c-1a57a67a9cfc", 1, "edaf5bf3-ae14-41d0-b8a4-8972f8940d73" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "6c2010eb-bf3a-429e-bc18-eae90ecaeb41", 1, "01ac1e29-2c73-4c8e-ac48-f3375993f45c" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "2c35e1e2-e423-453c-afbe-4b9200434d63", 1, "87ac41ee-ed08-460e-ac39-64de34025369" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "97dd7d82-2b20-4783-87c5-9d2f61c5cc7c", 1, "0534b7c2-7672-4268-9145-c38aec71a50b" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "f3d35666-36a1-4e5f-af6e-a83dc3e89f85", 1, "d9fcd40f-79a3-4d31-8dfa-986dcd0074f0" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "f407f428-a30c-4626-ad77-90c0e4ffedc0", 1, "7d34a009-dc54-4f24-b735-345ddf9bb754" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "ea60b4f4-02e4-4d5a-9d29-2102ee0bab80", 1, "f4098cc8-11e8-4757-81b4-c52f24250a0f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "050f9b2c-b61d-4eb2-9817-bbf3c74aa337", 1, "43507d74-6a28-483c-8f1d-2f462745fa16" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "7c819953-2c76-4382-ac36-c1b4969505dd", 1, "1a0a9c0f-bc51-46f2-a40c-fc962fd36c96" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "Gender", "SecurityStamp" },
                values: new object[] { "893dd9f8-0ba6-4c7a-b4a0-7adc1e59181f", 1, "acd6ef2e-cffc-4357-a1ea-598fa97507e8" });
        }
    }
}
