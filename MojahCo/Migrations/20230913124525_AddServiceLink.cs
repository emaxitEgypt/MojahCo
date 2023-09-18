using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojahCo.Migrations
{
    public partial class AddServiceLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ServiceLink",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServiceLink",
                table: "Services");
        }
    }
}
