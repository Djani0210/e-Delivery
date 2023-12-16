using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class RemoveVerificationCodeFor2FA : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VerificationCode",
                schema: "identity",
                table: "asp_net_users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VerificationCode",
                schema: "identity",
                table: "asp_net_users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
