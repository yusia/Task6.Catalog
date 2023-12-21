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

        // GET api/catalog/5
        [HttpGet("{id}")]
        public ActionResult<CatalogItem> Get(int id)
        {
            return _catalogSrv.GetItem(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
