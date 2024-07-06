using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class userPhoneNumber : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1167));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1170));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1175));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1178));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1181));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1183));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("2173657b-4ef6-42eb-a70f-3f81f205840a"), "Hello I have your order here!", new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4898), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("cf07f16a-c008-4b1b-a23b-ca5ba7bc7238"), "Hello your order is right outside!", new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4912), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("fbe6faea-cfed-4254-bbbb-f8582d39dead"), "Hello, where is your apartment?", new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4916), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1300));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1305));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1309));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1312));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1314));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1317));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1321));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1322));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1324));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1325));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1328));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1330));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1332));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1333));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1335));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1338));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1339));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1342));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1349));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1351));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3567));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3669));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3677));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3680));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3725));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3925));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3931));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3935));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3942));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3955));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3965));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3968));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3976));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3986));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4014));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4026));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4045));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4051));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4054));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4057));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4061));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4082));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4091));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4094));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4107));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3210));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3213));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3219));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3222));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3225));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3229));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3377));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1779));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1807));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1815));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1817));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1820));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1823));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4951));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4954));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4570));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4595));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4592));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4579));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4548));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3445));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3454));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3461));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3464));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(3468));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4824));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4828));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4831));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4834));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4838));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4840));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4843));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4847));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4853));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 0, 14, 14, 472, DateTimeKind.Local).AddTicks(4858));

            migrationBuilder.InsertData(
                table: "Verifications",
                columns: new[] { "Id", "Code", "ExpireDate", "IsConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("1c4bb5f0-6357-4cc0-bd96-1f026585998b"), "c7b3f0", new DateTime(2024, 7, 6, 0, 44, 14, 472, DateTimeKind.Local).AddTicks(5011), false, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("7978bb11-e877-4b06-9de3-0a041c473d2f"), "8a2f9b", new DateTime(2024, 7, 6, 0, 44, 14, 472, DateTimeKind.Local).AddTicks(4998), false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b") },
                    { new Guid("a281dd0d-eb81-48b8-b1fb-92cf75a5b269"), "41d0e5", new DateTime(2024, 7, 6, 0, 44, 14, 472, DateTimeKind.Local).AddTicks(5007), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") }
                });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "1de43e34-8583-4330-bcc5-bd07bbfcb597");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "1773d996-2753-40e5-a750-86224d89fdec");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "6b8c0955-5d41-497b-b181-ea8402c44c9e");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "5e7b891f-7096-45ed-9a14-ded6fb871088");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "d292131b-8b12-4937-9577-9bfdc820d47a", "061-111-120", "d5a768c7-317f-4394-8572-a09d3c987cbc" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "9f45d6a7-0696-4ca0-adc5-cb33ad8dd0f5", "061-111-122", "b368f370-02a3-41b7-86e8-031ebffb514c" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da40b88b-10fe-49af-bb7f-00468273d0f2", "459a8e67-a1c8-4a51-9fbc-078b88caba5f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b7b7e1ee-4464-436a-a301-c7039fff7a79", "061-111-123", "6364e6fd-2517-4a21-9222-2d38fa2ec838" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "0505ff86-0c32-4797-8ef3-3ad60b9d07bb", "395554c7-b382-4458-a333-b4ea7f5b8980" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "38faa185-b6d5-4dd8-8b70-e8d2f206ccde", "061-111-115", "1d0727a2-8171-413c-9242-a929f9a707be" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9a5d0012-d10a-45ba-88f0-bd76a537af78", "dde80bc6-f264-455f-ad5b-e78912d7ccfb" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "21c5a3ca-2f18-4f79-aab4-55cf409503ca", "061-111-118", "fae96c91-54d3-48a5-9a79-c7943d709dfd" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "85f445fd-2de7-4395-b468-7b9b9f180981", "061-111-119", "19908a50-d3f8-4c03-b071-d6967476cfb6" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "da22f41a-ffc7-4af5-983e-61d09c78055e", "061-111-121", "fb6162c1-b353-4370-84c3-771b64535d29" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "49bac677-b4d8-4ec2-846a-004f79464874", "60f10a7e-5298-48cc-b1cb-82ffdff518f2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "93d032b7-f27a-49d2-af76-215a3f9b0dd2", "061-111-117", "8371a4a0-17e5-41d5-9eb6-9c1882f6bc57" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "fd631146-a6fd-4d36-a92a-57085eac822c", "061-111-116", "6e4c3ab3-5a90-4c53-a838-f875a71ff7f2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdcd7f0c-db03-49e5-9e7a-a45b68d30453", "9b6be6fc-ba70-4000-8025-05ca9a075707" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("2173657b-4ef6-42eb-a70f-3f81f205840a"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("cf07f16a-c008-4b1b-a23b-ca5ba7bc7238"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("fbe6faea-cfed-4254-bbbb-f8582d39dead"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("1c4bb5f0-6357-4cc0-bd96-1f026585998b"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("7978bb11-e877-4b06-9de3-0a041c473d2f"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("a281dd0d-eb81-48b8-b1fb-92cf75a5b269"));

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
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b87a2624-b142-487a-b2b4-0ab44a60a383", "123456789", "2b2e81e7-032d-4c82-bc23-b35b9b5a25e2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "e9783d51-8dd3-425c-a49a-d5ef0b67f555", "123456789", "0408ee68-cacc-4562-bf96-49f5326dfb73" });

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
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "b7462d22-b28a-4c38-8e42-68635c2d8723", "123456789", "9ee159ff-aa00-44c2-a8f7-901a63b5fea4" });

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
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "67e95be6-a9e9-47d6-9c54-069c9c352dcf", "123456789", "4fe82d94-87db-483a-86bf-564c189b5bd4" });

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
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "40fc4cd4-708f-47f1-93de-ccd926a95587", "123456789", "a4925315-0e97-46c3-aea4-fc6f6b44b9d7" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "f22060ed-dc00-456f-99c4-e95f8b81d976", "123456789", "87adfed2-f8fa-4996-aa14-c0c9e19ceae5" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "9095478e-76b3-41fe-a3a4-6f95cd69ed5a", "123456789", "63fa6898-eb4c-44e6-860b-83e3d53a8c64" });

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
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "441e4e1b-f803-4cdf-8c35-ac32cce58048", "123456789", "ef14e78c-2061-4e25-997f-40ebdcd826c3" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "PhoneNumber", "SecurityStamp" },
                values: new object[] { "87304225-959c-4c16-9c59-fba902b16b79", "123456789", "6cacf782-000d-496e-9e2c-a6bf64f297fc" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "4da0efad-3f20-4269-9cb0-8a0367cdab9b", "3786f9b6-63ea-4472-88f8-48b5984bf437" });
        }
    }
}
