using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagmentSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "unitPrice",
                table: "SalesDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Laptops" },
                    { 2, "Dell Laptops" },
                    { 3, "HP Laptops" },
                    { 4, "Apple Laptops" },
                    { 5, "Lenovo Laptops" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "Contact", "Name" },
                values: new object[,]
                {
                    { 1, "One Dell Way, Round Rock, TX 78682, USA", "+1 800-456-3355", "Dell Technologies" },
                    { 2, "1501 Page Mill Road, Palo Alto, CA 94304, USA", "+1 800-474-6836", "HP Inc." },
                    { 3, "1 Infinite Loop, Cupertino, CA 95014, USA", "+1 800-275-2273", "Apple Inc." },
                    { 4, "6/F, Lenovo Building, 29 Science Park Road, Hong Kong", "+852 2833 2111", "Lenovo Group Limited" },
                    { 5, "3351 Michelson Drive, Suite 100, Irvine, CA 92612, USA", "+1 800-456-8000", "Ingram Micro" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Name", "Price", "SupplierId" },
                values: new object[,]
                {
                    { 1, 2, "Dell XPS 13", 1200.00m, 1 },
                    { 2, 3, "HP Spectre x360", 1300.00m, 2 },
                    { 3, 4, "MacBook Pro 14", 2000.00m, 3 },
                    { 4, 5, "Lenovo ThinkPad X1 Carbon", 1500.00m, 4 },
                    { 5, 2, "Dell Inspiron 15", 800.00m, 1 }
                });

            migrationBuilder.InsertData(
                table: "Stocks",
                columns: new[] { "LastUpdate", "ProductId", "Quantity", "Type" },
                values: new object[,]
                {
                    { new DateTime(2024, 3, 9, 12, 0, 0, 0, DateTimeKind.Utc), 1, 50, "Supply" },
                    { new DateTime(2024, 3, 9, 12, 5, 0, 0, DateTimeKind.Utc), 1, 20, "Sale" },
                    { new DateTime(2024, 3, 9, 12, 10, 0, 0, DateTimeKind.Utc), 2, 60, "Supply" },
                    { new DateTime(2024, 3, 9, 12, 15, 0, 0, DateTimeKind.Utc), 2, 30, "Sale" },
                    { new DateTime(2024, 3, 9, 12, 20, 0, 0, DateTimeKind.Utc), 3, 40, "Supply" },
                    { new DateTime(2024, 3, 9, 12, 25, 0, 0, DateTimeKind.Utc), 3, 10, "Sale" },
                    { new DateTime(2024, 3, 9, 12, 30, 0, 0, DateTimeKind.Utc), 4, 35, "Supply" },
                    { new DateTime(2024, 3, 9, 12, 35, 0, 0, DateTimeKind.Utc), 4, 15, "Sale" },
                    { new DateTime(2024, 3, 9, 12, 40, 0, 0, DateTimeKind.Utc), 5, 80, "Supply" },
                    { new DateTime(2024, 3, 9, 12, 45, 0, 0, DateTimeKind.Utc), 5, 50, "Sale" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 0, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 5, 0, 0, DateTimeKind.Utc), 1 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 10, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 15, 0, 0, DateTimeKind.Utc), 2 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 20, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 25, 0, 0, DateTimeKind.Utc), 3 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 30, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 35, 0, 0, DateTimeKind.Utc), 4 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 40, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.DeleteData(
                table: "Stocks",
                keyColumns: new[] { "LastUpdate", "ProductId" },
                keyValues: new object[] { new DateTime(2024, 3, 9, 12, 45, 0, 0, DateTimeKind.Utc), 5 });

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "unitPrice",
                table: "SalesDetails");
        }
    }
}
