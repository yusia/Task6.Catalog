using System;
using System.Collections.Generic;
using Task6.Catalog.Data;
using Task6.Catalog.Models;

namespace Task6.Catalog.Services
{
    public class CategoryService : ICategoryService
    {
        ICategoryRepository _catalogRepo;
        public CategoryService(ICategoryRepository data)
        {
            _catalogRepo = data;
        }
        public Category GetCategory(int id)
        {
            return _catalogRepo.GetCategory(id);
        }
        public IEnumerable<Category> GetCategories()
        {
            return _catalogRepo.GetCategories();
        }

        public void AddCategory(Category category)
        {
            _catalogRepo.AddCategory(category);
        }
        public void DeleteCategory(int id)
        {
            _catalogRepo.DeleteCategory(id);

        }
        public void UpdateCategory(Category category)
        {
            _catalogRepo.UpdateCategory(category);
        }
    }
}
