using BLL;
using DAL.Models;
using System;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;

public class ReportService
{
    private readonly SaleService _saleService;

    public ReportService()
    {
        _saleService = new SaleService();
    }

    public string GenerateHtmlReport(int saleid)
    {
        try
        {
            // تحديد المسار الصحيح للملف receipt.html داخل مجلد المشروع الرئيسي
            string projectDirectory = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectory, "receipt.html");

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException("Receipt template file not found.", filePath);
            }

            // قراءة القالب
            string htmlTemplate = File.ReadAllText(filePath);

            // جلب بيانات الفاتورة
            var sale = _saleService.GetSale(saleid);
            if (sale == null)
            {
                return null; // إذا لم يتم العثور على الفاتورة
            }

            // تجهيز بيانات الفاتورة
            string saleDate = sale.Date.ToString("yyyy-MM-dd");
            string customerName = string.IsNullOrEmpty(sale.Customer_Name) ? "Unknown" : sale.Customer_Name;

            string tableRows = string.Join(Environment.NewLine, sale.SalesDetails.Select(item =>
                $"<tr><td>{item.Product.Name}</td><td>{item.Quantity}</td><td>{item.unitPrice}</td><td>{item.Price}</td></tr>"));

            string totalPrice = sale.Total_Price.ToString();
            string finalHtml = htmlTemplate
                .Replace("{SaleDate}", saleDate)
                .Replace("{CustomerName}", customerName)
                .Replace("{TableRows}", tableRows)
                .Replace("{TotalPrice}", totalPrice);

            string tempFilePath = Path.Combine(Path.GetTempPath(), $"receipt_{saleid}.html");
            File.WriteAllText(tempFilePath, finalHtml);

            return tempFilePath;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error generating receipt: {ex.Message}");
            return null;
        }
    }
}