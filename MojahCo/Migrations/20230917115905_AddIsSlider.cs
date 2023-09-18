using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojahCo.Migrations
{
    public partial class AddIsSlider : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSlider",
                table: "ServiceImages",
                type: "bit",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSlider",
                table: "ServiceImages");
        }
    }
}
