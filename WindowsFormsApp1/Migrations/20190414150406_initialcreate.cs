using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WindowsFormsApp1.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "Acessuarys",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acessuarys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AmmoShops",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    ShopName = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    WorkTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AmmoShops", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    PersCode = table.Column<string>(nullable: true),
                    LicenseNumber = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true),
                    PersCode = table.Column<string>(nullable: true),
                    ReportsTo = table.Column<Guid>(nullable: false),
                    AmmoShopId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_AmmoShops_AmmoShopId",
                        column: x => x.AmmoShopId,
                        principalTable: "AmmoShops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Employees_Employees_ReportsTo",
                        column: x => x.ReportsTo,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ammos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WeaponTypeId = table.Column<Guid>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ammos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ammos_WeaponTypes_WeaponTypeId",
                        column: x => x.WeaponTypeId,
                        principalTable: "WeaponTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weapons",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    WeaponTypeId = table.Column<Guid>(nullable: false),
                    Price = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weapons_WeaponTypes_WeaponTypeId",
                        column: x => x.WeaponTypeId,
                        principalTable: "WeaponTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Purchases",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AmmoId = table.Column<Guid>(nullable: false),
                    WeaponId = table.Column<Guid>(nullable: false),
                    AcessuaryId = table.Column<Guid>(nullable: false),
                    AmmoShopId = table.Column<Guid>(nullable: false),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    CustomerId = table.Column<Guid>(nullable: false),
                    AmountOfAmmo = table.Column<int>(nullable: false),
                    AmountOfWeapon = table.Column<int>(nullable: false),
                    AmountOfAcessuary = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Purchases", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Purchases_Acessuarys_AcessuaryId",
                        column: x => x.AcessuaryId,
                        principalTable: "Acessuarys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_Ammos_AmmoId",
                        column: x => x.AmmoId,
                        principalTable: "Ammos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_AmmoShops_AmmoShopId",
                        column: x => x.AmmoShopId,
                        principalTable: "AmmoShops",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Purchases_Weapons_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "Weapons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ammos_WeaponTypeId",
                table: "Ammos",
                column: "WeaponTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_AmmoShopId",
                table: "Employees",
                column: "AmmoShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_ReportsTo",
                table: "Employees",
                column: "ReportsTo");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_AcessuaryId",
                table: "Purchases",
                column: "AcessuaryId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_AmmoId",
                table: "Purchases",
                column: "AmmoId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_AmmoShopId",
                table: "Purchases",
                column: "AmmoShopId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_CustomerId",
                table: "Purchases",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_EmployeeId",
                table: "Purchases",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Purchases_WeaponId",
                table: "Purchases",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_WeaponTypeId",
                table: "Weapons",
                column: "WeaponTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Purchases");

            migrationBuilder.DropTable(
                name: "Acessuarys");

            migrationBuilder.DropTable(
                name: "Ammos");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Weapons");

            migrationBuilder.DropTable(
                name: "AmmoShops");

            migrationBuilder.DropTable(
                name: "WeaponTypes");

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Age = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }
    }
}
