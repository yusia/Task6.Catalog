using System;
using System.Collections.Generic;
using Task6.Catalog.Models;

namespace Task6.Catalog.Data
{
    public interface ICatalogRepository
    {
        CatalogItem GetItem(int id);
        IEnumerable<CatalogItem> GetItems();
        IEnumerable<CatalogItem> GetItemsByCategory(int categoryId);
         void AddItem(CatalogItem item);
        void UpdateItem(CatalogItem item);
        void DeleteItem(int id);
    }
}
