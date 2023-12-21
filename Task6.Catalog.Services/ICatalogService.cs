using System;
using System.Collections.Generic;
using Task6.Catalog.Models;

namespace Task6.Catalog.Services
{
    public interface ICatalogService
    {
        CatalogItem GetItem(int id);
        IEnumerable<CatalogItem> GetItems();
    }
}
