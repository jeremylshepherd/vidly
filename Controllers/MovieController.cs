using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly
{
    public class MoviesController : Controller
    {

        List<Movie> movies = new List<Movie>{
            new Movie { Id = 1, Title = "Shrek", Year = 2001, Month = 5 },
            new Movie { Id = 2, Title = "Marvel's The Avengers", Year = 2012, Month = 5 },
            new Movie { Id = 3, Title = "Man of Steel", Year = 2013, Month = 6 }
        };

        public IActionResult Index()
        {
            var viewModel = new MoviesViewModel {
                Movies = movies
            };
            return View(viewModel);
        }

        public IActionResult Details(int Id)
        {
            var movie = movies.Where(i => Id == i.Id).FirstOrDefault();
            var viewModel = new MovieDetailsViewModel {
                Movie = movie
            };
            return View(viewModel);
        }

        [Route("movies/random/")]
        public IActionResult Random()
        {
            var movie = new Movie() { Title = "Shrek!" };
            var customers = new List<Customer>{
                new Customer { Name = "Customer 01" },
                new Customer { Name = "Customer 02" }
            };
            var viewModel = new RandomMovieViewModel {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/released/{year:int:minlength(4):maxlength(4)}/{month:int:range(1,12)}/")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year} & {month}");
        }

    }
}