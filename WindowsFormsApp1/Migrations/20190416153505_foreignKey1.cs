using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WindowsFormsApp1.Migrations
{
    public partial class foreignKey1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReportsTo",
                table: "Employees",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees");

            migrationBuilder.AlterColumn<Guid>(
                name: "ReportsTo",
                table: "Employees",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo",
                principalTable: "Employees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
