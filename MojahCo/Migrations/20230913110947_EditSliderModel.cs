using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MojahCo.Migrations
{
    public partial class EditSliderModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LongDescription",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Sliders",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LongDescription",
                table: "Sliders");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Sliders");
        }
    }
}
