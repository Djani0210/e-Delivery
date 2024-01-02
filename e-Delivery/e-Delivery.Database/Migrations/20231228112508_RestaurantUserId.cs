using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class RestaurantUserId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CreatedByUserId",
                table: "Restaurants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ModifiedByUserId",
                table: "Restaurants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_CreatedByUserId",
                table: "Restaurants",
                column: "CreatedByUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Restaurants_ModifiedByUserId",
                table: "Restaurants",
                column: "ModifiedByUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_asp_net_users_CreatedByUserId",
                table: "Restaurants",
                column: "CreatedByUserId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Restaurants_asp_net_users_ModifiedByUserId",
                table: "Restaurants",
                column: "ModifiedByUserId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_asp_net_users_CreatedByUserId",
                table: "Restaurants");

            migrationBuilder.DropForeignKey(
                name: "FK_Restaurants_asp_net_users_ModifiedByUserId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_CreatedByUserId",
                table: "Restaurants");

            migrationBuilder.DropIndex(
                name: "IX_Restaurants_ModifiedByUserId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "CreatedByUserId",
                table: "Restaurants");

            migrationBuilder.DropColumn(
                name: "ModifiedByUserId",
                table: "Restaurants");
        }
    }
}
