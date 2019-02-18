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
            Book b1 = new Book("Bob Dylan Chronicles", "James Stone", 20, "Books(2015)", "2332323", "ChroniclesBobDilan.jpg");
            Book b2 = new Book("Miles Autobiography", "Miles Arthur", 30, "Books(2018)", "445667", "MilesAutobiography.jpg");
            Book b3 = new Book("Revolution in the head", "Nick Stone", 30, "Books(2018)", "445667", "RevolutionInTheHead.jpg");


            // Initiate the MusicCD subclass and create an object for it
            MusicCD cd1 = new MusicCD("With the Beatles", "Beatles", 30, "CDBeatles.png");
            List<Track> tracks = new List<Track>() {
                cd1.addTrack("Song1", "Composer1"),
                cd1.addTrack("Song1", "Composer1")
            };
       

            MusicCD cd2 = new MusicCD("Bob Dylan - The collection", "Bob Dylan", 30, "BobDilanCD.jpg");

            

            MusicCD cd3 = new MusicCD("The real Miles Davis", "Miles Davis", 30, "MilesDavisCD.jpg");


            


            // assign a viewbag property to the new Book object
            ViewBag.B1 = b1;
            ViewBag.B2 = b2;
            ViewBag.B3 = b3;

            // assign a viewbag property to the new MusicCD object
            ViewBag.Cd1 = cd1;
            ViewBag.Cd2 = cd2;
            ViewBag.Cd3 = cd3;



            return View();
        }

       
    }
}