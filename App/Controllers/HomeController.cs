using System.Threading.Tasks;
using App.Core.Abstract;
using App.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IService<Categories> _service;
        private readonly IProductService _productService;
        private readonly IService<Products> _service2;

        public HomeController(ICategoryService categoryService, IService<Categories> service, IProductService productService, IService<Products> service2)
        {
            _categoryService = categoryService;
            _service = service;
            _productService = productService;
            _service2 = service2;
        }

        public async Task<IActionResult> Index()
        {
            var resultCategoriesWithProduct = await _categoryService.GetCategoryWithProducts(1);
            var categories = await _service.GetAllAsync();

            var resultProductsWithCategories = await _productService.GetProductsWithCategories(1);
            var products = await _service2.GetAllAsync();
            return View();
        }
    }
}
