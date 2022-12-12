using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using vidly.Models;
using vidly.ViewModels;
using System.Data.Entity;

namespace vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index(int? pageIndex, string sortBy) 
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrEmpty(sortBy))
                sortBy = "Name";

            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                //new Customer { Name = "hatem", Id = 1},
                //new Customer { Name = "Lss", Id = 2},
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }
        public ActionResult Detail(int id)
        {
            //if (!id.HasValue)
            //    return Content("please enter valid id");
            var movie = new Movie() { Name = "Shrek!" };

            if (id == 1)
            {
                var customers = new List<Customer>
                {
                    new Customer { Name = "hatem"},
                };
                var viewModel = new RandomMovieViewModel
                {
                    Movie = movie,
                    Customers = customers
                };
                return View(viewModel);
            }
            if (id == 2)
            {
                var customers = new List<Customer>
                {
                    new Customer { Name = "Lss"},
                };
                var viewModel = new RandomMovieViewModel
                {
                    Movie = movie,
                    Customers = customers
                };
                return View(viewModel);
            }
            return Content("please enter valid id");

        }
    }
}