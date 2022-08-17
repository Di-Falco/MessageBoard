using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageClient.Migrations
{
    public partial class ProfileIcons : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfileIcon",
                table: "AspNetUsers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfileIcon",
                table: "AspNetUsers");
        }
    }
}
