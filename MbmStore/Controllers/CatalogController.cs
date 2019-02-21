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
            cd1.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd1.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));
            cd1.addTrack(new Track("Step Inside Love", "Richard Rodgers", new TimeSpan(0, 2, 15)));
            cd1.addTrack(new Track("Los Paranoias", "John Lennon", new TimeSpan(0, 2, 05)));
            cd1.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd1.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));
            cd1.addTrack(new Track("Step Inside Love", "Richard Rodgers", new TimeSpan(0, 2, 15)));
            cd1.addTrack(new Track("Los Paranoias", "John Lennon", new TimeSpan(0, 2, 05)));




            MusicCD cd2 = new MusicCD("Bob Dylan - The collection", "Bob Dylan", 30, "BobDilanCD.jpg");
            cd2.addTrack(new Track("Blowin' in the Wind", "Don Hunstein", new TimeSpan(0, 2, 48)));
            cd2.addTrack(new Track("Girl from the North Country", "Don Hunstein", new TimeSpan(0, 2, 38)));
            cd2.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd2.addTrack(new Track("Blowin' in the Wind", "Don Hunstein", new TimeSpan(0, 2, 48)));
            cd2.addTrack(new Track("Girl from the North Country", "Don Hunstein", new TimeSpan(0, 2, 38)));
            cd2.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));

            MusicCD cd3 = new MusicCD("The real Miles Davis", "Miles Davis", 30, "MilesDavisCD.jpg");
            cd3.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd3.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd3.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));
            cd3.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd3.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd3.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));



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