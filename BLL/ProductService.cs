using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class ProductService
    {
        private readonly InventoryDbContext dbContext;
        public ProductService()
        {
            dbContext = new InventoryDbContext();
        }
        public void Add(string name,decimal price,int categoryId,int supplierId,int quantity)
        {
            var newProduct = dbContext.Products.Include(p => p.Stocks).FirstOrDefault(p => p.Name == name);
            if (newProduct == null)
            {
                Product product = new Product()
                {
                    Name = name,
                    Price = price,
                    CategoryId = categoryId,
                    SupplierId = supplierId
                };
                dbContext.Products.Add(product);
                dbContext.SaveChanges();
                Stock stock = new Stock()
                {
                    Type = "Supply",
                    Quantity = quantity,
                    LastUpdate = DateTime.Now,
                    ProductId = product.ProductId
                };
                dbContext.Stocks.Add(stock);
                dbContext.SaveChanges();
            }
            else
            {
                Stock newStock = new Stock()
                {
                    Type = "Supply",
                    Quantity = quantity,
                    LastUpdate = DateTime.Now,
                    ProductId = newProduct.ProductId
                };
                dbContext.Stocks.Add(newStock);
                dbContext.SaveChanges();
            }
        }
        public void Update(int id,string name, decimal price, int categoryId, int supplierId)
        {
            //validate on categoryId - supplierId
            var product =GetById(id);
            if(product != null)
            {
                product.Name = name;
                product.Price = price;
                product.CategoryId = categoryId;
                product.SupplierId = supplierId;

                dbContext.Products.Update(product);
                dbContext.SaveChanges();
            }
        }
        public void Delete(int id)
        {
            var product = dbContext.Products.Where(p =>p.ProductId == id).FirstOrDefault();

            if (product != null)
            {
                //dbContext.Stocks.RemoveRange(product.Stocks);
                dbContext.Products.Remove(product);
                dbContext.SaveChanges();
            }
        }
        public IEnumerable<object> GetAll()
        {
            //return all products   (exist and not exist in stock)
            //return dbContext.Products.Include(p => p.Category).Include(p => p.Supplier).ToList();
            //return dbContext.Products.ToList();

            //return only products that have quantity in stock
            var products = dbContext.Products.Include(p => p.Category)
                                     .Include(p => p.Supplier)
                                     .Include(p => p.Stocks)
                                     .Where(p => p.Stocks.Any(s => s.Quantity > 0 ))
                                     .Select(p => new
                                     {
                                         p.ProductId,
                                         p.Name,
                                         p.Price,
                                         CategoryName = p.Category.Name,
                                         SupplierName = p.Supplier.Name,
                                         TotalStock = (p.Stocks.Where(s => s.Type == "Supply").Sum(s => (int?)s.Quantity) ?? 0) -
                                                 (p.Stocks.Where(s => s.Type == "Sale").Sum(s => (int?)s.Quantity) ?? 0)

                                     })
                                     .ToList();
            return products;
        }
        public Product? GetById(int id)
        {
            //return dbContext.Products.Where(p => p.ProductId == id).FirstOrDefault();
            var product = dbContext.Products.Where(p => p.ProductId == id)
                                     .Include(p => p.Category)
                                     .Include(p => p.Supplier)
                                     .Include(p => p.Stocks)
                                     .FirstOrDefault();

            if(product != null)
            {
                return product;
            }
            return null;
        }
        public IEnumerable<object> Search(string name, int? categoryId, int? supplierId)
        {
            var query = dbContext.Products
                         .Include(p => p.Category)
                         .Include(p => p.Supplier)
                         .Include(p => p.Stocks)
                         .Where(p => p.Stocks.Any(s => s.Quantity > 0 && s.Type == "Supply"))
                         .AsQueryable();

            if (!string.IsNullOrEmpty(name))
            {
                query = query.Where(p => p.Name.Contains(name));
            }

            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId);
            }
            if (supplierId != null)
            {
                query = query.Where(p => p.SupplierId == supplierId);
            }

            var result = query.Select(p => new
            {
                p.ProductId,
                p.Name,
                p.Price,
                CategoryName = p.Category.Name,
                SupplierName = p.Supplier.Name,
                TotalStock = p.Stocks.Where(s => s.Type == "Supply").Sum(s => s.Quantity)
            }).ToList();
            return result;
        }
        public Product ViewDetails(int id)
        {
            return GetById(id)!;
        }

        public int GetTotalCount()
        {
            return GetAll().Count();
        }
        public int GetLowStockProdCount()
        {
            var result = GetAll().ToList();
            return result.Count(p => (int)p.GetType().GetProperty("TotalStock").GetValue(p) < 10);
        }

    }
}
