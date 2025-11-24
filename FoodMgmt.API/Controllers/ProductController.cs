using FoodMgmt.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FoodMgmt.API.Controllers
{
    public class ProductController : Controller
    {
        private IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("GetAllProducts")]
        public IActionResult Index()
        {
            return (IActionResult)_productService.GetProduct();
        }
    }
}
