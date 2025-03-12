﻿using System;
using System.Collections.Generic;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class SaleService
    {
        private readonly InventoryDbContext context;

        public SaleService()
        {
            context = new InventoryDbContext();
        }
        public Sale GetSale(int id)
        {
            return context.Sales.OrderBy(x => x.Id).LastOrDefault(x => x.Id == id)!;
        }
        public bool AddSale(DateTime date, string customerName, decimal totalPrice )
        {
            var sale = new Sale
            {
                Date = date,
                Customer_Name = customerName,
                Total_Price = totalPrice
            };

            context.Add(sale);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public bool UpdateSale(int id, DateTime date, string customerName, decimal totalPrice)
        {
            var oldSale = context.Sales.Find(id);
            if (oldSale == null)
            {
                return false;
            }

            oldSale.Customer_Name = customerName;
            oldSale.Date = date;
            oldSale.Total_Price = totalPrice;

            context.Sales.Update(oldSale);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public bool DeleteSale(int id)
        {
            var sale = context.Sales.Find(id);
            if (sale == null)
            {
                return false;
            }

            context.Sales.Remove(sale);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }

        public List<Sale> GetAllSales()
        {
            return context.Sales.ToList();
        }

        public Sale? GetSaleById(int id)
        {
            var sale = context.Sales.Find(id);
            return sale != null ? sale : null;
        }
        public decimal GetTotalRevenue()
        {
            return context.Sales.Sum(s => s.Total_Price);
        }

        public int GetTotalCustomers()
        {
            return context.Sales.Select(s => s.Customer_Name).Distinct().Count();
        }
        public int GetTotalOrders()
        {
            return context.Sales.Count();
        }

        public Sale GetLastSaleWithNoName()
        {
            return context.Sales.OrderBy(c => c.Id).LastOrDefault(s => s.Customer_Name == "noname")!;
        }
        public List<Sale> GetSalesWithoutNoName()
        {
            return context.Sales.Where(n => n.Customer_Name != "noname").ToList();
        }
        public bool AddSale(string name)
        {

            var lastsale = GetLastSaleWithNoName();
            // var mysale = GetSaleById(lastsale.Id);
            //when add product create sale without name to use saleId , as soon as finish , add name . 
            if (string.IsNullOrEmpty(name))
            {
                var sale = new Sale
                {
                    Date = DateTime.Now,
                    Customer_Name = "noname",
                    Total_Price = 0,
                };

                context.Add(sale);
            }
            else
            {
                if (lastsale != null)
                {
                    lastsale!.Customer_Name = name;
                    lastsale.Total_Price = GetTotalPrice();
                    context.Update(lastsale);
                }
            }
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }
        public decimal GetTotalPrice()
        {
            var sale = context.Sales.Include(s => s.SalesDetails).OrderBy(x => x.Id).LastOrDefault();
            decimal totalprice = 0;
            foreach (var item in sale!.SalesDetails)
            {
                totalprice += item.Price;
            }
            return totalprice;
        }
        public List<Sale> GetAll()
        {
            return context.Sales.ToList();
        }
    }
}
