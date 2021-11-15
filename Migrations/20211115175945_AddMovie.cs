using Microsoft.EntityFrameworkCore.Migrations;

namespace Cinema.Migrations
{
    public partial class AddMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Time",
                table: "Movies",
                newName: "PlayingTime");

            migrationBuilder.RenameColumn(
                name: "Date",
                table: "Movies",
                newName: "PlayingDate");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PlayingTime",
                table: "Movies",
                newName: "Time");

            migrationBuilder.RenameColumn(
                name: "PlayingDate",
                table: "Movies",
                newName: "Date");
        }
    }
}
