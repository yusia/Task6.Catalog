using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task6.Catalog.Models;
using Task6.Catalog.Services;

namespace Task6.Catalog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CatalogController : ControllerBase
    {
        ICatalogService _catalogSrv;

        public CatalogController(ICatalogService srv)
        {
            _catalogSrv = srv;
        }
        // GET api/catalog
        [HttpGet]
        public ActionResult<IEnumerable<CatalogItem>> Get()
        {
            return _catalogSrv.GetItems().ToList();
        }

        [HttpGet]
        [Route("api/[controller]")]
        public ActionResult<CatalogItem> Get(int id)
        {
            return _catalogSrv.GetItem(id);
        }

        [HttpGet("api/catalog/category/{id}")]
        public ActionResult<IEnumerable<CatalogItem>> GetByCategory(int id)
        {
            return _catalogSrv.GetItemsByCategory(id).ToList();
        }

        [HttpPost]
        public void Post([FromBody] CatalogItem item)
        {
            //todo set category
            _catalogSrv.AddItem(item);

        }

        [HttpPut("{id}")]
        public void Put([FromBody] CatalogItem  item)
        {
            _catalogSrv.UpdateItem(item);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _catalogSrv.DeleteItem(id);
        }
    }
}
