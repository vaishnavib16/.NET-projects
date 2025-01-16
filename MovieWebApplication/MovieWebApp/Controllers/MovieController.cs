//using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using MovieWebApp.Entity;
using MovieWebApp.Services;

namespace MovieWebApp.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {

        private readonly MovieInterface movimpl;

        public MovieController(MovieInterface movimpl)
        {
            this.movimpl = movimpl;
        }

        [HttpPost]
        public IActionResult Insert(Movie movie)
        {
            movimpl.Insert(movie);
            return Ok();
        }

        [HttpGet]
        public IActionResult Display()
        {
            return Ok(movimpl.GetAll());
        }

        [HttpPut]
        public IActionResult Update(Movie movie)
        {
            movimpl.Update(movie);
            return Ok();
        }

        [HttpPost ("{id}")]

    }
}
