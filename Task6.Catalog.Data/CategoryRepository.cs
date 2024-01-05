using System;
using System.Collections.Generic;
using Task6.Catalog.Models;

namespace Task6.Catalog.Data
{
    public class CategoryRepository : ICategoryRepository
    {
        List<Category> dataCategory = new List<Category>{
                new Category() { Id = 0, Type = "Techno" },
                new Category() { Id = 1, Type = "Dishes"} };


        public Category GetCategory(int id)
        {
            return dataCategory.Find(i => i.Id == id);
        }

        public IEnumerable<Category> GetCategories()
        {
            return dataCategory;
        }

        public void AddCategory(Category Category)
        {
            dataCategory.Add(Category);
        }
        public void DeleteCategory(int id)
        {
            var Category = GetCategory(id);
            dataCategory.Remove(Category);
        }

        public void UpdateCategory(Category Category)
        {
            var CategoryToUpdate = dataCategory.Find(i => i.Id == Category.Id);
            if (CategoryToUpdate != null)
            {
                CategoryToUpdate.Type = Category.Type;
            }
        }
    }
}
