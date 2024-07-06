using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class sideDishIsDeleted : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SideDishes",
                type: "bit",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 1,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 2,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 3,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 4,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 5,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 6,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 7,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 8,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 9,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 10,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 11,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 12,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 13,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 14,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 15,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 21,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 22,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 23,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 24,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 25,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 26,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 27,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 28,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 29,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 30,
                column: "IsDeleted",
                value: false);

            migrationBuilder.UpdateData(
                table: "SideDishes",
                keyColumn: "Id",
                keyValue: 31,
                column: "IsDeleted",
                value: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SideDishes");

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "d292131b-8b12-4937-9577-9bfdc820d47a", "d5a768c7-317f-4394-8572-a09d3c987cbc" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("29f648d1-4b82-4bf9-be7c-dc690b6edbf9"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "9f45d6a7-0696-4ca0-adc5-cb33ad8dd0f5", "b368f370-02a3-41b7-86e8-031ebffb514c" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "b7b7e1ee-4464-436a-a301-c7039fff7a79", "6364e6fd-2517-4a21-9222-2d38fa2ec838" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "38faa185-b6d5-4dd8-8b70-e8d2f206ccde", "1d0727a2-8171-413c-9242-a929f9a707be" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "21c5a3ca-2f18-4f79-aab4-55cf409503ca", "fae96c91-54d3-48a5-9a79-c7943d709dfd" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("b8cd72fb-eac5-40d5-8b22-7e8d601e2760"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "85f445fd-2de7-4395-b468-7b9b9f180981", "19908a50-d3f8-4c03-b071-d6967476cfb6" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("bb5f8b53-1b9c-404f-86c4-6c6036102045"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "da22f41a-ffc7-4af5-983e-61d09c78055e", "fb6162c1-b353-4370-84c3-771b64535d29" });

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
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "93d032b7-f27a-49d2-af76-215a3f9b0dd2", "8371a4a0-17e5-41d5-9eb6-9c1882f6bc57" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("e7286ada-7ad6-4bb4-8b0a-436141928671"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "fd631146-a6fd-4d36-a92a-57085eac822c", "6e4c3ab3-5a90-4c53-a838-f875a71ff7f2" });

            migrationBuilder.UpdateData(
                schema: "identity",
                table: "asp_net_users",
                keyColumn: "Id",
                keyValue: new Guid("fd8eeeae-94c0-4f7c-ae8d-04274d13031b"),
                columns: new[] { "ConcurrencyStamp", "SecurityStamp" },
                values: new object[] { "bdcd7f0c-db03-49e5-9e7a-a45b68d30453", "9b6be6fc-ba70-4000-8025-05ca9a075707" });
        }
    }
}
