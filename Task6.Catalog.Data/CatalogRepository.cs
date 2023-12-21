using System;
using System.Collections.Generic;
using Task6.Catalog.Models;

namespace Task6.Catalog.Data
{
    public class CatalogRepository : ICatalogRepository
    {
        List<CatalogItem> data =  new List<CatalogItem>{
                new CatalogItem() { Id = 0, Name = "Cup", Price = 100 },
                new CatalogItem() { Id = 1, Name = "Kettle", Price = 300 }
    };
    public CatalogItem GetItem(int id)
        {
            return data.Find(i => i.Id == id);
        }

        public IEnumerable<CatalogItem> GetItems()
        {
            return data;
        }
    }
}
