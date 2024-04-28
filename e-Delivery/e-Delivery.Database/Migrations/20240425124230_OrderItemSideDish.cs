using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class OrderItemSideDish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrderItemSideDish",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false),
                    SideDishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItemSideDish", x => new { x.OrderItemId, x.SideDishId });
                    table.ForeignKey(
                        name: "FK_OrderItemSideDish_OrderItems_OrderItemId",
                        column: x => x.OrderItemId,
                        principalTable: "OrderItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItemSideDish_SideDishes_SideDishId",
                        column: x => x.SideDishId,
                        principalTable: "SideDishes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItemSideDish_SideDishId",
                table: "OrderItemSideDish",
                column: "SideDishId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItemSideDish");
        }
    }
}
