using Microsoft.EntityFrameworkCore.Migrations;

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
                     SUM(s.Quantity) AS StockLevel
                 FROM dbo.Products p
                 INNER JOIN dbo.Stocks s ON p.ProductId = s.ProductId
                 Where s.Type ='Supply'
                 GROUP BY p.Name
                 HAVING SUM(s.Quantity) > 0
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
                     COALESCE(SUM(s.Quantity), 0) AS StockLevel
                 FROM dbo.Products p
                 LEFT JOIN dbo.Stocks s ON p.ProductId = s.ProductId
                 GROUP BY p.ProductId, p.Name
                 HAVING COALESCE(SUM(s.Quantity), 0) < 10
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
                     SUM(sd.Quantity) AS TotalSold
                 FROM dbo.SalesDetails sd
                 JOIN dbo.Products p ON sd.ProductId = p.ProductId
                 GROUP BY p.ProductId, p.Name
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
