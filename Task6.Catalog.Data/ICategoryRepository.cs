using System;
using System.Collections.Generic;
using Task6.Catalog.Models;

namespace Task6.Catalog.Data
{
    public interface ICategoryRepository
    {
        Category GetCategory(int id);
        IEnumerable<Category> GetCategories();
         void AddCategory(Category Category);
        void UpdateCategory(Category Category);
        void DeleteCategory(int id);
    }
}
