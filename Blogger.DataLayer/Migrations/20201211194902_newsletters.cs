using Microsoft.EntityFrameworkCore.Migrations;

namespace Blogger.DataLayer.Migrations
{
    public partial class newsletters : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActiveNewsLetter",
                table: "Users",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActiveNewsLetter",
                table: "Users");
        }
    }
}
