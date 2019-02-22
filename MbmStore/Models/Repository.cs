using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MbmStore.Models;

namespace MbmStore.Models
{
    public class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        //Create objects
        
        static Repository() {
            //Books
            Book b1 = new Book("Bob Dylan Chronicles", "James Stone", 20, "Books(2015)", "2332323", "ChroniclesBobDilan.jpg");
            Book b2 = new Book("Miles Autobiography", "Miles Arthur", 30, "Books(2018)", "445667", "MilesAutobiography.jpg");
            Book b3 = new Book("Revolution in the head", "Nick Stone", 30, "Books(2018)", "445667", "RevolutionInTheHead.jpg");
          

            ///////CDs
            //CD1
            MusicCD cd1 = new MusicCD("With the Beatles", "Beatles", 30, "CDBeatles.png");
            cd1.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd1.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));
            cd1.addTrack(new Track("Step Inside Love", "Richard Rodgers", new TimeSpan(0, 2, 15)));
            cd1.addTrack(new Track("Los Paranoias", "John Lennon", new TimeSpan(0, 2, 05)));
            cd1.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd1.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));
            cd1.addTrack(new Track("Step Inside Love", "Richard Rodgers", new TimeSpan(0, 2, 15)));
            cd1.addTrack(new Track("Los Paranoias", "John Lennon", new TimeSpan(0, 2, 05)));

            //CD2

             MusicCD cd2 = new MusicCD("Bob Dylan - The collection", "Bob Dylan", 30, "BobDilanCD.jpg");
            cd2.addTrack(new Track("Blowin' in the Wind", "Don Hunstein", new TimeSpan(0, 2, 48)));
            cd2.addTrack(new Track("Girl from the North Country", "Don Hunstein", new TimeSpan(0, 2, 38)));
            cd2.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd2.addTrack(new Track("Blowin' in the Wind", "Don Hunstein", new TimeSpan(0, 2, 48)));
            cd2.addTrack(new Track("Girl from the North Country", "Don Hunstein", new TimeSpan(0, 2, 38)));
            cd2.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));

            //CD3
            MusicCD cd3 = new MusicCD("The real Miles Davis", "Miles Davis", 30, "MilesDavisCD.jpg");
            cd3.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd3.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd3.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));
            cd3.addTrack(new Track("Down the Highway", "Don Hunstein", new TimeSpan(0, 2, 07)));
            cd3.addTrack(new Track("I Will", "Richard Rodgers", new TimeSpan(0, 2, 20)));
            cd3.addTrack(new Track("Blue Moon", "Richard Rodgers", new TimeSpan(0, 2, 52)));

            ///Movie objects
            Movie jungleBook = new Movie("Jungle Book", 160.50m, "junglebook.jpg", "Ridley Scott");
            Movie becomingAstrid = new Movie("Becoming Astrid", 200.10m, "becomingAstrid.png", "Ridley Scott");
            Movie starBorn = new Movie("A star is born", 180.10m, "starBorn.png", "Ridley Scott");

        }
    }
}