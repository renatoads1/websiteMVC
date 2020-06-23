using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Weba2mvc.Models;
using Weba2mvc.Services;
namespace Weba2mvc.Controllers
{
    public class ProductsController : Controller
    {

        private readonly ProductService _productService;
        public ProductsController(ProductService productService)
        {
            _productService = productService;
        }
        public IActionResult Index()
        {
            var list = _productService.FindAll();
            return View(list);
        }
    }
}
