using System;
using System.Collections.Generic;
using Task6.Catalog.Models;

namespace Task6.Catalog.Services
{
    public interface ICategoryService
    {
        Category GetCategory(int id);
        IEnumerable<Category> GetCategories();
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(int id);
    }
}
