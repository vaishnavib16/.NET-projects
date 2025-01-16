using Microsoft.AspNetCore.Mvc;
using ProductApplication.Models;
using ProductApplication.Services;

namespace ProductApplication.Controllers
{
    public class ProductControllercs : Controller
    {
        private readonly ProductInteface prodimpl;

        public ProductControllercs(ProductInteface prodimpl)
        {
            this.prodimpl = prodimpl;
        }

        [HttpPost]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult insert()
        {

           
            return View();
        }

        [HttpPost]
        public IActionResult insert(Product product)
        {
            
            prodimpl.insert(product);
            return View(product);
        }


       

        [HttpGet]
        public IActionResult delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult delete(int id)
        {
            prodimpl.delete(id);
            return View();
        }
    }
}
