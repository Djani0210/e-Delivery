using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class fixingImages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodItems_Images_LogoId",
                table: "FoodItems");

            migrationBuilder.DropIndex(
                name: "IX_FoodItems_LogoId",
                table: "FoodItems");

            migrationBuilder.DropColumn(
                name: "LogoId",
                table: "FoodItems");

            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedByUserId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

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
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Images_CreatedByUserId",
                table: "Images",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_ModifiedByUserId",
                table: "Images",
                column: "ModifiedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodItemPictures_FoodItemId",
                table: "FoodItemPictures",
                column: "FoodItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_asp_net_users_CreatedByUserId",
                table: "Images",
                column: "CreatedByUserId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_asp_net_users_ModifiedByUserId",
                table: "Images",
                column: "ModifiedByUserId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
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

            migrationBuilder.DropTable(
                name: "FoodItemPictures");

            migrationBuilder.DropIndex(
                name: "IX_Images_CreatedByUserId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_ModifiedByUserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "LogoId",
                table: "FoodItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_FoodItems_LogoId",
                table: "FoodItems",
                column: "LogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodItems_Images_LogoId",
                table: "FoodItems",
                column: "LogoId",
                principalTable: "Images",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }
    }
}
