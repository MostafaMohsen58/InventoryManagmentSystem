using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagmentSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Customer_Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Total_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Role = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 30, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesDetails",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    unitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesDetails", x => new { x.ProductId, x.SaleId });
                    table.ForeignKey(
                        name: "FK_SalesDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesDetails_Sales_SaleId",
                        column: x => x.SaleId,
                        principalTable: "Sales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Stocks",
                columns: table => new
                {
                    LastUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stocks", x => new { x.LastUpdate, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Stocks_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Smartphones" },
                    { 2, "Tablets" },
                    { 3, "Accessories" },
                    { 4, "Cameras" },
                    { 5, "Monitors" },
                    { 6, "Laptops" }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "Customer_Name", "Date", "Total_Price" },
                values: new object[,]
                {
                    { 1, "Omar", new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 90000m },
                    { 2, "Mohamed", new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 154000m },
                    { 3, "Ali", new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 68000m },
                    { 4, "Nader", new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 150000m },
                    { 5, "Ahmed", new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 84000m },
                    { 6, "Sara", new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 56000m }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "Contact", "Name" },
                values: new object[,]
                {
                    { 1, "Samsung Town, Seoul, South Korea", "82 2 2053 3000", "Samsung" },
                    { 2, "1 Apple Park Way, Cupertino, CA 95014, USA", "1 800 275 2273", "Apple Inc." },
                    { 3, "1-7-1 Konan, Minato-ku, Tokyo, Japan", "81 3 6748 2111", "Sony" },
                    { 4, "LG Twin Towers, Seoul, South Korea", "82 2 3777 1114", "LG Electronics" },
                    { 5, "30-2, Shimomaruko 3-chome, Ota-ku, Tokyo, Japan", "81 3 3758 2111", "Canon" },
                    { 6, "Shinagawa Intercity Tower C, 2-15-3, Konan, Minato-ku, Tokyo, Japan", "81 3 6433 3600", "Nikon" },
                    { 7, "Round Rock, Texas, USA", "1 800 624 9897", "Dell" },
                    { 8, "1501 Page Mill Road, Palo Alto, CA 94304, USA", "1 650 857 1501", "HP" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Password", "Role", "UserName" },
                values: new object[,]
                {
                    { 1, "123456789", "Admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "SupplierId" },
                values: new object[,]
                {
                    { 1, 1, "Samsung Galaxy S24", 18000m, 1 },
                    { 2, 1, "iPhone 15 Pro Max", 22000m, 2 },
                    { 3, 2, "iPad Pro 12.9", 17000m, 2 },
                    { 4, 2, "Samsung Galaxy Tab S9", 15000m, 1 },
                    { 5, 4, "Sony Alpha a7 IV", 25000m, 3 },
                    { 6, 5, "LG UltraGear 32", 14000m, 4 },
                    { 7, 4, "Canon EOS R5", 28000m, 5 },
                    { 8, 4, "Nikon Z9", 30000m, 6 },
                    { 9, 6, "Dell XPS 15", 20000m, 7 },
                    { 10, 6, "HP Spectre x360", 18000m, 8 }
                });

            migrationBuilder.InsertData(
                table: "SalesDetails",
                columns: new[] { "ProductId", "SaleId", "Price", "Quantity", "unitPrice" },
                values: new object[,]
                {
                    { 1, 1, 90000m, 5, 18000m },
                    { 2, 2, 154000m, 7, 22000m },
                    { 3, 3, 68000m, 4, 17000m },
                    { 5, 4, 150000m, 6, 25000m },
                    { 7, 5, 84000m, 3, 28000m },
                    { 9, 6, 40000m, 2, 20000m },
                    { 10, 6, 16000m, 1, 16000m }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "LastUpdate", "ProductId", "Quantity", "Type" },
                values: new object[,]
                {
                    { new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 3, "Sale" },
                    { new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 15, "Supply" },
                    { new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 25, "Supply" },
                    { new DateTime(2025, 1, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 6, "Sale" },
                    { new DateTime(2025, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 4, "Sale" },
                    { new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 10, "Supply" },
                    { new DateTime(2025, 2, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2, "Sale" },
                    { new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 20, "Supply" },
                    { new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 8, "Supply" },
                    { new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 7, "Sale" },
                    { new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1, "Sale" },
                    { new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 5, "Supply" },
                    { new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 12, "Supply" },
                    { new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 2, "Sale" },
                    { new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 40, "Supply" },
                    { new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 18, "Supply" },
                    { new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 35, "Supply" },
                    { new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 5, "Sale" },
                    { new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4, "Sale" },
                    { new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 5, "Sale" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_SalesDetails_SaleId",
                table: "SalesDetails",
                column: "SaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_ProductId",
                table: "Stocks",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SalesDetails");

            migrationBuilder.DropTable(
                name: "Stocks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
