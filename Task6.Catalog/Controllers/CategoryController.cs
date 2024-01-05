using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Task6.Catalog.Models;
using Task6.Catalog.Models.Exceptions;
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
        public ActionResult Post([FromBody] Category Category)
        {
            _categorySrv.AddCategory(Category);
            return Ok();
        }

        [HttpPut("{id}")]
        public ActionResult Put([FromBody] Category Category)
        {
            try
            {
                _categorySrv.UpdateCategory(Category);

                return Ok();
            }
            catch (ItemNotFoundException ex)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _categorySrv.DeleteCategory(id);
                return Ok();
            }
            catch (ItemNotFoundException ex)
            {
                return NotFound();
            }
        }
    }
}
