using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;

namespace MbmStore.Controllers
{
    public class CatalogController : Controller
    {

        // GET: Catalog
        public ActionResult Index()
        {
           
        // Initiate the Book subclass and create an object for it

            List<Book> books = new List<Book>();
            books = Repository.Products.OfType<Book>().ToList();


            List<MusicCD> musicCD = new List<MusicCD>();
            musicCD = Repository.Products.OfType<MusicCD>().ToList();



           


            // assign a viewbag property to the new Book object
            ViewBag.Books = books;
      

            // assign a viewbag property to the new MusicCD object
            ViewBag.MusicCD = musicCD;
   


            return View();
        }

        public ActionResult MyCatalog()
        {
            var data = Repository.GetProducts();
            return View(data);
        }
    }
}