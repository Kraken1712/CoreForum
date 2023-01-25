using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyForum.DAL.Migrations
{
    public partial class Last_Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Comments");

            migrationBuilder.AddColumn<string>(
                name: "Picname",
                table: "Comments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Picname",
                table: "Comments");

            migrationBuilder.AddColumn<byte>(
                name: "Img",
                table: "Comments",
                type: "tinyint",
                nullable: true);
        }
    }
}
