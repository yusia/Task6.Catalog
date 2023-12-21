using System;
using System.Collections.Generic;
using Task6.Catalog.Data;
using Task6.Catalog.Models;

namespace Task6.Catalog.Services
{
    public class CatalogService : ICatalogService
    {
        ICatalogRepository _catalogRepo;
        public CatalogService(ICatalogRepository data)
        {
            _catalogRepo = data;
        }
        public CatalogItem GetItem(int id)
        {
            return _catalogRepo.GetItem(id);
        }
        public IEnumerable<CatalogItem> GetItems()
        {
            return _catalogRepo.GetItems();
        }
    }
}
