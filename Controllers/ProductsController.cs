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

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product) 
        {
            _productService.Insert(product);
            return RedirectToAction(nameof(Index));
        
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product obj = _productService.FindById(id.Value);
            if (obj == null) 
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _productService.Remove(id);
            return RedirectToAction(nameof(Index));            
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product obj = _productService.FindById(id.Value);
            if(obj==null)
            {
                return NotFound();
            }
            return View(obj);
        }
        
    }
}
