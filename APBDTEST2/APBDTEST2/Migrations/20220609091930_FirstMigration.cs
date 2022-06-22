using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace APBDTEST2.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    IdClient = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.IdClient);
                });

            migrationBuilder.CreateTable(
                name: "Confectioneries",
                columns: table => new
                {
                    IdConfectionery = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PricePerOne = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Confectioneries", x => x.IdConfectionery);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    IdEmployee = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.IdEmployee);
                });

            migrationBuilder.CreateTable(
                name: "ClientOrders",
                columns: table => new
                {
                    IdClientOrder = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CompletionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IdClient = table.Column<int>(type: "int", nullable: false),
                    IdEmployee = table.Column<int>(type: "int", nullable: false),
                    IdClientNavIdClient = table.Column<int>(type: "int", nullable: true),
                    IdEmployeeNavIdEmployee = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientOrders", x => x.IdClientOrder);
                    table.ForeignKey(
                        name: "FK_ClientOrders_Clients_IdClientNavIdClient",
                        column: x => x.IdClientNavIdClient,
                        principalTable: "Clients",
                        principalColumn: "IdClient",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ClientOrders_Employees_IdEmployeeNavIdEmployee",
                        column: x => x.IdEmployeeNavIdEmployee,
                        principalTable: "Employees",
                        principalColumn: "IdEmployee",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ConfOrders",
                columns: table => new
                {
                    IdClientOrder = table.Column<int>(type: "int", nullable: false),
                    IdConfectionery = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    IdClientOrderNavIdClientOrder = table.Column<int>(type: "int", nullable: true),
                    IdConfectioneryNavIdConfectionery = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Confectionery_ClientOrder_PK", x => new { x.IdClientOrder, x.IdConfectionery });
                    table.ForeignKey(
                        name: "FK_ConfOrders_ClientOrders_IdClientOrderNavIdClientOrder",
                        column: x => x.IdClientOrderNavIdClientOrder,
                        principalTable: "ClientOrders",
                        principalColumn: "IdClientOrder",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ConfOrders_Confectioneries_IdConfectioneryNavIdConfectionery",
                        column: x => x.IdConfectioneryNavIdConfectionery,
                        principalTable: "Confectioneries",
                        principalColumn: "IdConfectionery",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ClientOrders",
                columns: new[] { "IdClientOrder", "Comments", "CompletionDate", "IdClient", "IdClientNavIdClient", "IdEmployee", "IdEmployeeNavIdEmployee", "OrderDate" },
                values: new object[,]
                {
                    { 1, "vlalvalal", new DateTime(2000, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, 1, null, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "vlalvalal222222", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, null, 2, null, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "IdClient", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "John", "Maw" },
                    { 2, "Sara", "Curry" }
                });

            migrationBuilder.InsertData(
                table: "ConfOrders",
                columns: new[] { "IdClientOrder", "IdConfectionery", "Amount", "Comments", "IdClientOrderNavIdClientOrder", "IdConfectioneryNavIdConfectionery" },
                values: new object[,]
                {
                    { 1, 1, 1, "dsasda", null, null },
                    { 2, 2, 2, "dsasda222222222", null, null }
                });

            migrationBuilder.InsertData(
                table: "Confectioneries",
                columns: new[] { "IdConfectionery", "Name", "PricePerOne" },
                values: new object[,]
                {
                    { 1, "Whatever1", 5f },
                    { 2, "Whatever2", 10f }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "IdEmployee", "FirstName", "LastName" },
                values: new object[,]
                {
                    { 1, "JohnE", "MawE" },
                    { 2, "SaraE", "CurryE" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrders_IdClientNavIdClient",
                table: "ClientOrders",
                column: "IdClientNavIdClient");

            migrationBuilder.CreateIndex(
                name: "IX_ClientOrders_IdEmployeeNavIdEmployee",
                table: "ClientOrders",
                column: "IdEmployeeNavIdEmployee");

            migrationBuilder.CreateIndex(
                name: "IX_ConfOrders_IdClientOrderNavIdClientOrder",
                table: "ConfOrders",
                column: "IdClientOrderNavIdClientOrder");

            migrationBuilder.CreateIndex(
                name: "IX_ConfOrders_IdConfectioneryNavIdConfectionery",
                table: "ConfOrders",
                column: "IdConfectioneryNavIdConfectionery");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConfOrders");

            migrationBuilder.DropTable(
                name: "ClientOrders");

            migrationBuilder.DropTable(
                name: "Confectioneries");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
