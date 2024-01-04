using System;
using System.Collections.Generic;
using Task6.Catalog.Models;

namespace Task6.Catalog.Data
{
    public class CatalogRepository : ICatalogRepository
    {
        List<Category> dataCategory = new List<Category>{
                new Category() { Id = 0, Type = "Techno" },
                new Category() { Id = 1, Type = "Dishes"} };
        List<CatalogItem> data;

        public CatalogRepository()
        {
          data = new List<CatalogItem>{
                new CatalogItem() { Id = 0, Name = "Cup", Price = 100  , CategoryType = dataCategory[0]},
                new CatalogItem() { Id = 1, Name = "Kettle", Price = 300  , CategoryType = dataCategory[1]},
                new CatalogItem() { Id = 2, Name = "Plate", Price = 150 , CategoryType = dataCategory[0] },};


        }

        public CatalogItem GetItem(int id)
        {
            return data.Find(i => i.Id == id);
        }

        public IEnumerable<CatalogItem> GetItems()
        {
            return data;
        }
        public IEnumerable<CatalogItem> GetItemsByCategory(int categoryId)
        {
             return data.FindAll(i => i.CategoryType.Id == categoryId);
        }
        public void AddItem(CatalogItem item)
        {
            data.Add(item);
        }
        public void DeleteItem(int id)
        {
            var item = GetItem(id);
            data.Remove(item);
        }

        public void UpdateItem(CatalogItem item)
        {
            var itemToUpdate =data.Find(i => i.Id == item.Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = item.Name;
                itemToUpdate.Price = item.Price;
            }
        }
    }
}
