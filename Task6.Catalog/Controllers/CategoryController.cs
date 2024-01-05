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
    public class CategoryController : ControllerBase
    {
        ICategoryService _categorySrv;

        public CategoryController(ICategoryService srv)
        {
            _categorySrv = srv;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Category>> Get()
        {
            return _categorySrv.GetCategories().ToList();
        }
        /* List of categories
Add category
Update category
Delete category*/

        [HttpGet("{id}")]
        public ActionResult<Category> Get(int id)
        {
            return _categorySrv.GetCategory(id);
        }

        [HttpPost]
        public void Post([FromBody] Category Category)
        {
            _categorySrv.AddCategory(Category);
        }

        [HttpPut("{id}")]
        public void Put([FromBody] Category Category)
        {
            _categorySrv.UpdateCategory(Category);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _categorySrv.DeleteCategory(id);
        }
    }
}
