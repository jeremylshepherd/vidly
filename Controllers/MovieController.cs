using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace vidly
{
    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            return Content("Index route for Movies");
        }

        [Route("movies/random/")]
        public IActionResult Random()
        {
            return Content("Random randomness");
        }

        [Route("movies/released/{year}/{month}/")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year} & {month}");
        }

    }
}