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
        public bool DeleteCategory(int id)
        {
            var category = context.Categories.Find(id);
            if (category == null)
            {
                return false;
            }

            context.Categories.Remove(category);
            var rowsAffected = context.SaveChanges();
            return rowsAffected > 0;
        }
        public List<Category> GetAllCategories()
        {
            return context.Categories.ToList();
        }
    }
}
