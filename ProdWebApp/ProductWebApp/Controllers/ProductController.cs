//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ProductWebApp.Entity;
using ProductWebApp.Services;

namespace ProductWebApp.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductInterface prodtl;



        public ProductController(ProductInterface prodtl)
        {
            this.prodtl = prodtl;
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
            prodtl.Insert(product);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            prodtl.Update(product);
            return Ok();
        }

        [HttpGet]

        public IActionResult Display()
        {
            return Ok(prodtl.GetAll());
        }

        [HttpPost("{Id}")]
        public IActionResult Delete(int Id)
        {
            prodtl.Delete(Id);
            return Ok();
        }
    }
}
