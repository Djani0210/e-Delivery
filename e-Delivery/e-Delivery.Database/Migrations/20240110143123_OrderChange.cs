using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class OrderChange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Payment_intent_id",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Receipt_url",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "OrderItems");

            migrationBuilder.AddColumn<string>(
                name: "SideDishIds",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SideDishIds",
                table: "OrderItems");

            migrationBuilder.AddColumn<string>(
                name: "Payment_intent_id",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Receipt_url",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "OrderItems",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
