using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormsApp1.Migrations
{
    public partial class fullNameForEmployee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Surname",
                table: "Employees",
                newName: "FullName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "Surname");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Employees",
                nullable: true);
        }
    }
}
