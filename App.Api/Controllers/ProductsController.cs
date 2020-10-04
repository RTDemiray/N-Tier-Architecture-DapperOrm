using System.Threading.Tasks;
using App.Core.Abstract;
using App.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IService<Products> _service;

        public ProductsController(IProductService productService, IService<Products> service)
        {
            _productService = productService;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}/categories")]
        public async Task<IActionResult> GetProductsWithCategories(int id)
        {
            return Ok(await _productService.GetProductsWithCategories(id));
        }
    }
}
