﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagmentSystem.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddStoredProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // Create Stored Procedure for Current Stock Levels

            migrationBuilder.Sql(@"
             CREATE PROCEDURE GetCurrentStockLevels
             AS
             BEGIN
                 SET NOCOUNT ON;
             
                 SELECT  
                     p.Name AS ProductName,
                     ISNULL(SUM(CASE WHEN s.Type = 'Supply' THEN s.Quantity ELSE 0 END), 0) - 
                     ISNULL(SUM(CASE WHEN s.Type = 'Sale' THEN s.Quantity ELSE 0 END), 0) AS StockLevel
                 FROM dbo.Products p
                 INNER JOIN dbo.Stocks s ON p.ProductId = s.ProductId
                 GROUP BY p.Name
                 HAVING 
                     ISNULL(SUM(CASE WHEN s.Type = 'Supply' THEN s.Quantity ELSE 0 END), 0) - 
                     ISNULL(SUM(CASE WHEN s.Type = 'Sale' THEN s.Quantity ELSE 0 END), 0) > 0
                 ORDER BY StockLevel DESC;
             END;
             ");


            // Create Stored Procedure for Monthly Sales Performance
            migrationBuilder.Sql(@"
             CREATE PROCEDURE GetMonthlySalesPerformance
             AS
             BEGIN
                 SET NOCOUNT ON;
                 SELECT 
                     FORMAT(s.Date, 'yyyy-MM') AS Month, 
                     SUM(DISTINCT s.Total_Price) AS TotalSales, -- Fix duplication issue
                     COUNT(DISTINCT s.Id) AS NumberOfSales, 
                     SUM(sd.Quantity) AS TotalProductsSold -- Correct count of total sold products
                 FROM dbo.Sales s 
                 JOIN dbo.SalesDetails sd ON s.Id = sd.SaleId
                 GROUP BY FORMAT(s.Date, 'yyyy-MM')
                 ORDER BY Month DESC;
             END;
         ");

            // Stored Procedure for Low-Stock Products
            migrationBuilder.Sql(@"
             CREATE PROCEDURE GetLowStockProducts
               AS
               BEGIN
                   SET NOCOUNT ON;
                   SELECT 
                       p.ProductId, 
                       p.Name AS ProductName, 
                       ISNULL(SUM(CASE WHEN s.Type = 'Supply' THEN s.Quantity ELSE 0 END), 0) - 
                       ISNULL(SUM(CASE WHEN s.Type = 'Sale' THEN s.Quantity ELSE 0 END), 0) AS StockLevel
                   FROM dbo.Products p
                   INNER JOIN dbo.Stocks s ON p.ProductId = s.ProductId
                   GROUP BY p.ProductId, p.Name
                   HAVING 
               	ISNULL(SUM(CASE WHEN s.Type = 'Supply' THEN s.Quantity ELSE 0 END), 0) - 
                       ISNULL(SUM(CASE WHEN s.Type = 'Sale' THEN s.Quantity ELSE 0 END), 0) < 10
                   ORDER BY StockLevel ASC;
               END;
         ");

            //Stored Procedure for Most Sold Products
            migrationBuilder.Sql(@"
             CREATE PROCEDURE GetMostSoldProducts 
             AS
             BEGIN
                 SET NOCOUNT ON;
             
                 SELECT 
                     p.ProductId, 
                     p.Name AS ProductName, 
                     ISNULL(SUM(s.Quantity), 0) AS TotalSold
                 FROM dbo.Products p
                 INNER JOIN dbo.Stocks s ON p.ProductId = s.ProductId
                 WHERE s.Type = 'Sale'  -- Only consider sales transactions
                 GROUP BY p.ProductId, p.Name
                 HAVING ISNULL(SUM(s.Quantity), 0) > 0
                 ORDER BY TotalSold DESC;
             
             END;
         ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // Drop the stored procedures if rolling back the migration
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetCurrentStockLevels;");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetMonthlySalesPerformance;");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetLowStockProducts;");
            migrationBuilder.Sql("DROP PROCEDURE IF EXISTS GetMostSoldProducts;");
        }
    }
}
