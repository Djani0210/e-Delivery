using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace e_Delivery.Database.Migrations
{
    /// <inheritdoc />
    public partial class UserInImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_asp_net_users_Images_LogoId",
                schema: "identity",
                table: "asp_net_users");

            migrationBuilder.DropIndex(
                name: "IX_asp_net_users_LogoId",
                schema: "identity",
                table: "asp_net_users");

            migrationBuilder.DropColumn(
                name: "LogoId",
                schema: "identity",
                table: "asp_net_users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserProfilePictureId",
                table: "Images",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_UserProfilePictureId",
                table: "Images",
                column: "UserProfilePictureId");

            migrationBuilder.AddForeignKey(
                name: "FK_Images_asp_net_users_UserProfilePictureId",
                table: "Images",
                column: "UserProfilePictureId",
                principalSchema: "identity",
                principalTable: "asp_net_users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_asp_net_users_UserProfilePictureId",
                table: "Images");

            migrationBuilder.DropIndex(
                name: "IX_Images_UserProfilePictureId",
                table: "Images");

            migrationBuilder.DropColumn(
                name: "UserProfilePictureId",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "LogoId",
                schema: "identity",
                table: "asp_net_users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_asp_net_users_LogoId",
                schema: "identity",
                table: "asp_net_users",
                column: "LogoId");

            migrationBuilder.AddForeignKey(
                name: "FK_asp_net_users_Images_LogoId",
                schema: "identity",
                table: "asp_net_users",
                column: "LogoId",
                principalTable: "Images",
                principalColumn: "Id");
        }
    }
}
