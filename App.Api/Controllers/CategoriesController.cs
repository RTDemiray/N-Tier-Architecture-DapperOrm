using System.Threading.Tasks;
using App.Core.Abstract;
using App.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IService<Categories> _service;

        public CategoriesController(ICategoryService categoryService, IService<Categories> service)
        {
            _categoryService = categoryService;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}/products")]
        public async Task<IActionResult> GetCategoriesWithProducts(int id)
        {
            return Ok(await _categoryService.GetCategoryWithProducts(id));
        }
    }
}
