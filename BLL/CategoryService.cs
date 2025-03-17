using System;
using System.Collections.Generic;
using DAL;
using DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace BLL
{
    public class CategoryService
    {
        private readonly InventoryDbContext context;

        public CategoryService()
        {
            context = new InventoryDbContext(); ;
        }
        public bool AddCategory(string name)
        {
            var category = new Category
            {
                Name = name
            };

            context.Add(category);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }
        public bool UpdateCategory(int id, string name)
        {
            var oldCategory = context.Categories.Find(id);
            if (oldCategory == null)
            {
                return false;
            }

            oldCategory.Name = name;
            context.Categories.Update(oldCategory);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }
        public string DeleteCategory(int id)
        {
            var category = context.Categories.Find(id);
            if (category == null)
            {
                return "The category is not available.";
            }
            var hasProducts = context.Products.Any(p => p.CategoryId == id);

            if (hasProducts)
            {
                return "The category cannot be deleted because it is associated with products.";
            }
            context.Categories.Remove(category);
            context.SaveChanges();
            return "Category deleted successfully!";
        }
        public List<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }
    }
}
