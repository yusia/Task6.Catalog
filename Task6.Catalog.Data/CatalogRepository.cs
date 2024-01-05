using System;
using System.Collections.Generic;
using Task6.Catalog.Models;
using Task6.Catalog.Models.Exceptions;

namespace Task6.Catalog.Data
{
    public class CatalogRepository : ICatalogRepository
    {
        List<CatalogItem> data;

        public CatalogRepository(ICategoryRepository categRepo )
        {
          data = new List<CatalogItem>{
                new CatalogItem() { Id = 0, Name = "Cup", Price = 100  , CategoryType = categRepo.GetCategory(0)},
                new CatalogItem() { Id = 1, Name = "Kettle", Price = 300  , CategoryType = categRepo.GetCategory(1)},
                new CatalogItem() { Id = 2, Name = "Plate", Price = 150 , CategoryType = categRepo.GetCategory(0) },};

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
            if (item != null)
            {
                data.Remove(item);
            }
            else throw new ItemNotFoundException();
        }

        public void UpdateItem(CatalogItem item)
        {
            var itemToUpdate =data.Find(i => i.Id == item.Id);
            if (itemToUpdate != null)
            {
                itemToUpdate.Name = item.Name;
                itemToUpdate.Price = item.Price;
            }
            else throw new ItemNotFoundException();
        }
    }
}
