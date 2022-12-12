using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;

namespace vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index(int? pageIndex, string sortBy) // ActionResult is the base for all results in .Net
            // actually u can put it as ViewResult
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrEmpty(sortBy))
                sortBy = "Name";
            return Content(String.Format("page index = {0}, sortBy = {1}", pageIndex, sortBy));
            // these parameters cant be in the url bc theyr 2 para except u do a custom route
            // u can put them in the query in the url though after the ?
        }
        public ActionResult random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "hatem"},
                new Customer { Name = "Lss"},
                new Customer { Name = "hatem"},
                new Customer { Name = "Lss"},
                new Customer { Name = "hatem"},
                new Customer { Name = "Lss"}
            };

            var viewModel = new RandomMovieViewModel 
            {
                Movie = movie,
                Customers = customers
            };
            //ViewData["Movie"] = movie; // old way with magic string
            //ViewBag.Movie = movie; // magic property
            return View(viewModel); // View is inherited from the controller class - an easy way to call ViewResult - ViewResult.ViewData.Model
        }
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        [Route("movies/released/{year:range(1988,2100)}/{month:range(1,12)}")]
        public ActionResult MoviesByReleaseDate(int year = 2000, int month = 12)
        {
            return Content(string.Format("year = {0} month = {1}", year, month));
        }
    }
}