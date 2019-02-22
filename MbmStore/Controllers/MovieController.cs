using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Index()
        {
           
        // Initiate the Book subclass and create an object for it
            List<Movie> movies = new List<Movie>();
            movies = Repository.Products.OfType<Movie>().ToList();

            // assign a viewbag property to the new Movie object
            ViewBag.Movies = movies;

            return View();
        }
    }
}