using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class idontknow : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("c59237ad-7fc5-4c69-8a8d-3e78dbf7371c"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("dbb2687b-961c-46c5-a180-ed1858c2dbff"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("fd0054cd-56d9-4bdb-82df-81e380fef40f"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("31473fe8-20e0-4587-880a-9e29f48bc741"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("b1617645-f966-4db8-b215-0cba4b45dd1f"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("ebbe80e2-2130-4116-a7e2-669a55c6266d"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8371));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8379));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8380));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8384));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("47f32d54-5193-4a86-b9c7-c7621ff0f6e2"), "Hello, where is your apartment?", new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(627), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("8138aaf3-1370-45d3-9f08-89b95a3e6407"), "Hello your order is right outside!", new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(624), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("a9bde764-62fe-4679-a4a4-074b7604af07"), "Hello I have your order here!", new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(616), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8912));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8917));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8921));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8923));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8925));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8926));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8929));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8932));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8935));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8962));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/hamburger.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cheeseburger.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/margarita.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 4,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/capricoza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 5,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/funghi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 6,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/fileti.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 7,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sausage.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 8,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sendvicklasik.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 9,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickensendvic.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 10,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pepperoni.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 11,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sacher.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 12,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 13,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 14,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/dzempalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 15,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/margarita.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 16,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/capricoza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 17,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/funghi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 18,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pepperonipizza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 19,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/fileti.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 20,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 21,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 22,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/greeksalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 23,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/tomatosalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 24,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/regularsalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 25,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sendvicklasik.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 26,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickensendvic.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 27,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 28,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/friedsquid.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 29,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/friedsquid.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 30,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pastrmka.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 31,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pastrmka.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 32,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/beefsteak.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 33,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickenskewers.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 34,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickenskewers.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 35,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 36,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 37,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/regularsalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 38,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/tomatosalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 39,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/greeksalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 40,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 41,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 42,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 43,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 44,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/fileti.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 45,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 46,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 47,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/dolma.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 48,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/japrak.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 49,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/bibermeso.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 50,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/bosanskilonac.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 51,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/hamburger.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 52,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cheeseburger.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 53,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/margarita.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 54,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/capricoza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 55,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/greeksalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 56,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/fileti.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 57,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sendvicklasik.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 58,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickensendvic.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 59,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 60,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 61,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/dzempalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 62,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/margarita.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 63,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/capricoza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 64,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/carbonara.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 65,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/bolognese.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 66,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pesto.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 67,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/lasagne.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 68,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 69,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/dzempalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9730));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9733));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9749));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9759));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9761));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9771));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9774));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9777));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9783));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9787));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9790));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9796));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9807));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9811));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9816));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9819));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9860));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9864));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9869));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9872));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9884));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9890));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9896));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9901));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9911));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9917));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9930));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9935));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9938));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9941));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9954));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9997));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9578));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9590));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9603));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9458));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9470));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9473));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9518));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9528));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9532));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9534));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9536));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9539));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9541));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9544));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9556));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(384));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(354));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9643));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 240, DateTimeKind.Local).AddTicks(9652));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(551));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(561));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(563));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(566));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(569));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(574));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(577));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(585));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 23, 27, 1, 241, DateTimeKind.Local).AddTicks(587));

            migrationBuilder.InsertData(
                table: "Verifications",
                columns: new[] { "Id", "Code", "ExpireDate", "IsConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("5ec32ccc-8c85-4d2d-a67c-7b7eb5f41431"), "41d0e5", new DateTime(2024, 7, 6, 23, 57, 1, 241, DateTimeKind.Local).AddTicks(740), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") },
                    { new Guid("7ed47802-10bf-4217-a521-0379af47d885"), "c7b3f0", new DateTime(2024, 7, 6, 23, 57, 1, 241, DateTimeKind.Local).AddTicks(743), false, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("8d2a780c-3a6d-4605-b028-51c3343c101e"), "8a2f9b", new DateTime(2024, 7, 6, 23, 57, 1, 241, DateTimeKind.Local).AddTicks(735), false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b") }
                });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "1accc234-46d8-41dc-879d-bef05b76c1cb");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "3ac95dbd-64d5-4675-b37f-83582c51634f");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "0b6fb9fb-2b47-47b1-93e5-88bc0f3455e2");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "bb2df6ee-b17c-47c9-9f15-28904d6c72c9");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c20347da-a682-4676-a18c-d3a33b7170f0", "95f50f91-daf3-47be-88ab-6ab6f6eb3c6f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "841cd3ea-fc42-489a-8b9f-8e7d9a67720c", "03ec39fa-a5f0-44d2-81e8-b0ef9b490216" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "40fd6bbe-d7e5-4f71-9cc6-0e3390f5172a", "0ae05aef-8b01-4772-a20f-eed51b30c8df" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fb83e3ac-9b57-43ca-940a-90df690cb3ae", "7f183d7d-5199-4e40-9bf1-574af502c86b" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "ae44c593-7c6f-4c92-8899-fb3a62811920", "c95d5d15-9577-46c2-9af2-3d71d5b2268e" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "159ec311-a0ba-4e85-8d80-cdec399e14f9", "a01170ef-c409-4c79-a1d5-e6edcdc1859e" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c6c04c8a-ad38-4193-9a34-bb817de7b80e", "f70f5908-9a8d-4e75-ba7b-7d72975b1050" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6596d68b-4c2f-4c39-a031-06ba59e3195f", "92aa6aa2-16dd-4cbe-b320-9dd674a7a954" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "61df6d36-046c-495a-88f0-54bfc3fd6a9f", "f4d9df55-a664-4e55-9840-a0367ebb616a" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7e9e5cbe-5c15-41a7-99fc-c4e9f1d28836", "04260026-960c-42d3-a858-b9a600052f3f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9b38332d-a682-4e89-81fa-8216e676d6d2", "b04b293c-dd0b-407a-8b1b-6e2efc293bf8" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "a76fa74d-0e5e-4768-9d6a-601e2b08c829", "791cfd30-ab2b-4cf8-9046-91e26fc0fe58" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "6d16e5ae-f0c4-4fd2-91d4-bc549feb34a5", "02ec81d0-5c89-4645-93f7-e438ee8f314f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "12ec6ca1-4a93-48ef-ad34-6be42ee8e0a5", "3ecb3912-139b-4d08-8677-73fe9b967905" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("47f32d54-5193-4a86-b9c7-c7621ff0f6e2"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("8138aaf3-1370-45d3-9f08-89b95a3e6407"));

            migrationBuilder.DeleteData(
                table: "Chats",
                keyColumn: "Id",
                keyValue: new Guid("a9bde764-62fe-4679-a4a4-074b7604af07"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("5ec32ccc-8c85-4d2d-a67c-7b7eb5f41431"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("7ed47802-10bf-4217-a521-0379af47d885"));

            migrationBuilder.DeleteData(
                table: "Verifications",
                keyColumn: "Id",
                keyValue: new Guid("8d2a780c-3a6d-4605-b028-51c3343c101e"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2756));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2762));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2764));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2771));

            migrationBuilder.InsertData(
                table: "Chats",
                columns: new[] { "Id", "Content", "CreatedDate", "IsDeleted", "UserFromId", "UserToId" },
                values: new object[,]
                {
                    { new Guid("c59237ad-7fc5-4c69-8a8d-3e78dbf7371c"), "Hello your order is right outside!", new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4669), false, new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("dbb2687b-961c-46c5-a180-ed1858c2dbff"), "Hello, where is your apartment?", new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4672), false, new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("fd0054cd-56d9-4bdb-82df-81e380fef40f"), "Hello I have your order here!", new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4663), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"), new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") }
                });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2940));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2947));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2949));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2953));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2956));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2957));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2959));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2960));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2963));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2965));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2968));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2973));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2974));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2976));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2977));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2980));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2982));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2985));

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/hamburger.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cheeseburger.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 3,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/margarita.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 4,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/capricoza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 5,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/funghi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 6,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/fileti.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 7,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sausage.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 8,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sendvicklasik.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 9,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickensendvic.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 10,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pepperoni.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 11,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sacher.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 12,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 13,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 14,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/dzempalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 15,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/margarita.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 16,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/capricoza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 17,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/funghi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 18,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pepperonipizza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 19,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/fileti.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 20,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 21,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 22,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/greeksalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 23,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/tomatosalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 24,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/regularsalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 25,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sendvicklasik.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 26,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickensendvic.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 27,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 28,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/friedsquid.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 29,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/friedsquid.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 30,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pastrmka.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 31,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pastrmka.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 32,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/beefsteak.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 33,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickenskewers.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 34,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickenskewers.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 35,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 36,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 37,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/regularsalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 38,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/tomatosalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 39,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/greeksalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 40,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 41,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 42,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 43,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cevapi.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 44,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/fileti.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 45,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 46,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 47,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/dolma.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 48,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/japrak.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 49,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/bibermeso.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 50,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/bosanskilonac.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 51,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/hamburger.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 52,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/cheeseburger.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 53,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/margarita.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 54,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/capricoza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 55,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/greeksalad.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 56,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/fileti.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 57,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/sendvicklasik.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 58,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/chickensendvic.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 59,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 60,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/nutellapalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 61,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/dzempalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 62,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/margarita.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 63,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/capricoza.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 64,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/carbonara.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 65,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/bolognese.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 66,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/pesto.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 67,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/lasagne.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 68,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/baklava.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItemPictures",
                keyColumn: "Id",
                keyValue: 69,
                column: "FileName",
                value: "http://localhost:44395/FoodItem_images/dzempalacinke.jpg");

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3710));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3718));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3721));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3734));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3738));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3780));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3784));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3787));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3793));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3798));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3800));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3804));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3811));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3814));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3817));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3821));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3827));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3830));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3833));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3839));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3842));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3854));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3857));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3861));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3868));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3871));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3874));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3918));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3921));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3924));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3930));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 47,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 49,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3943));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 50,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3946));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 51,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3949));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 52,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3952));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 53,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3954));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 54,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3957));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 55,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3960));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 56,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3963));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 57,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 58,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3969));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 59,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3972));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 60,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3975));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 61,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 62,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3981));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 63,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 64,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 65,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3989));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 66,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 67,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 68,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "FoodItems",
                keyColumn: "Id",
                keyValue: 69,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3599));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3604));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3608));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3613));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3620));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "Images",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3625));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3462));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3474));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3477));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3479));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3487));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3489));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3494));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3498));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3552));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3555));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3558));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3560));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3566));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3571));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4697));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4700));

            migrationBuilder.UpdateData(
                table: "Notifications",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4703));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0167003f-76d8-4736-9010-9f4f756c5107"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4447));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("098f1a2e-656c-4b65-9429-be1a4f1022e7"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4401));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("0c54c236-4ec5-40e4-b354-2d50e9000778"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("15073c29-56ff-4762-8a86-a4211339e0f9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4406));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("1991b3fc-5625-49fe-ab51-9ab5495340a9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4433));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("328ba3f4-7f21-40f2-ada2-f4f55eaef398"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4419));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("365fd8d6-8de9-4693-bd61-84eb1526c9d9"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4453));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("425aaa01-bd25-4cae-a267-433e6fef7818"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4450));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("4cc493e7-886e-425b-83d7-0c433bf07a9c"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4427));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("51fe2fb5-761e-40eb-9518-3be0e95a9af6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4436));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("551bf252-ccac-49a9-ade0-5b82db0025f6"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4425));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("5fd9e288-163c-4286-bb40-02213f53198f"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4441));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("650327a7-1218-4306-aca5-cb30ef57de36"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4444));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("81dcd144-67d4-4117-ab76-b511689c9cc2"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4431));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("8ce9b7ba-ccff-422c-acc9-ed0a704dacaf"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("e87e91f7-0b36-4c08-83bc-774aacb99ab8"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4415));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("faf51d20-4224-4894-940e-1d916274b611"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: new Guid("ff454850-5665-4246-aa6f-738cb80aa325"),
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4439));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3653));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3661));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3665));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3668));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "Restaurants",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 6, 14, 21, 30, 320, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.InsertData(
                table: "Verifications",
                columns: new[] { "Id", "Code", "ExpireDate", "IsConfirmed", "UserId" },
                values: new object[,]
                {
                    { new Guid("31473fe8-20e0-4587-880a-9e29f48bc741"), "c7b3f0", new DateTime(2024, 7, 6, 14, 51, 30, 320, DateTimeKind.Local).AddTicks(4784), false, new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045") },
                    { new Guid("b1617645-f966-4db8-b215-0cba4b45dd1f"), "8a2f9b", new DateTime(2024, 7, 6, 14, 51, 30, 320, DateTimeKind.Local).AddTicks(4744), false, new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b") },
                    { new Guid("ebbe80e2-2130-4116-a7e2-669a55c6266d"), "41d0e5", new DateTime(2024, 7, 6, 14, 51, 30, 320, DateTimeKind.Local).AddTicks(4781), false, new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1") }
                });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("353224f4-7950-428d-a141-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "690628a6-69f4-4ace-8e79-ea24b9807c69");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("67c0d30a-d873-4f9b-a143-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "44ae5c97-9ec2-4783-9bdd-c0ce1ff4d946");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("7d7168d4-ef7e-4503-a144-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "3c5865ea-6602-490c-8bc2-7ab79cf144e1");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_roles",
                keyColumn: "Id",
                keyValue: new Guid("f57f872c-eaa4-441e-a142-08dc2a5ba67c"),
                column: "ConcurrencyStamp",
                value: "e44b1c7e-932d-4046-81e9-020b9caecf91");

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("1bb03af4-c9c6-42f4-8153-dfd0e427bb43"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "06d34516-03ea-4aee-8a8e-d2f291d6ffb0", "e34516ac-17ba-43a6-bee3-e1bec3d8ed0d" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "15c0e4cb-1431-4da9-b602-a92627d4cb35", "0a708d6e-be04-4935-9acc-f009baf9d2fd" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("4325ff27-c4d1-4ee8-8073-518fafba8678"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "575ae419-9502-4584-a112-5fd57a0328b4", "d51a4c8a-317c-455c-9666-f40cfa82ad94" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("531cbf7f-0aa1-44b2-8186-83867ac6e257"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1f3c9960-8637-46dd-bae6-81dd8c4c3bed", "801186b0-c3d2-40c2-a63f-a03c25a1c67a" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6c932e9e-d350-4103-bd77-c2716d6f4a1f"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9c99cd99-9e99-404d-a071-49fa5d43d40c", "d0877d28-cae8-4c41-984f-e213d484491f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("6f43201b-919e-471f-9ca7-4f4d0c74ca39"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fbcf2b0e-7d93-4756-809a-02b7bd5a6bba", "6ea7b5c3-6626-4052-8259-8daef7b3a079" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("a6262414-844d-4003-9184-1a39fcc8d621"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "e725714f-b87a-4b6b-90b5-02fe47c6c95f", "33d1b7a0-037a-4af8-9cc0-a4c8362f88e8" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8396f1d-a29a-4856-a4c1-1312dc97a4a1"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "1eda62eb-1f54-4654-b19f-e4089a8fcfba", "f3566498-e3ef-47c0-a520-30acebe9b1b5" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "8027f98d-5d32-4429-9787-1842d4b1da09", "58467073-66d0-4eb9-a110-18ba21267dfc" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "c2e2ca04-f36d-48cc-8f90-febf387644c5", "473c7505-ce39-4a0d-b4a2-cbab119a8d2f" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bcc3036b-fcde-4aae-8d5a-7d3b85a91310"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "3c273298-526d-4874-9338-d187ca8b4b2b", "b913127b-bf2a-439f-9cd8-0de188cfa1da" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("d405edf6-6ebf-4c20-861d-077f70fbcfb7"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "971fb52f-8cf6-4989-8151-708a650766f5", "f89e5ba9-2388-4ca8-8959-e6379e59f2bf" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "7fb464a9-b130-46a8-820e-a011dde005ee", "a19adcaa-86df-42f7-b1e5-e9bdd9d79184" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "f77a127d-bd4e-4b7f-bf77-b63429a91668", "b442ebae-250e-4fb4-a4f5-ab269456cb7a" });
        }
    }
}
