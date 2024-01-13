using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class ReviewList : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SideDishes_OrderItems_OrderItemId",
                table: "SideDishes");

            migrationBuilder.DropIndex(
                name: "IX_SideDishes_OrderItemId",
                table: "SideDishes");

            migrationBuilder.DropColumn(
                name: "OrderItemId",
                table: "SideDishes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "OrderItemId",
                table: "SideDishes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SideDishes_OrderItemId",
                table: "SideDishes",
                column: "OrderItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_SideDishes_OrderItems_OrderItemId",
                table: "SideDishes",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id");
        }
    }
}
