using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MbmStore.Models;
namespace MbmStore.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            // create a new Movie object with instance name Customer, using the constructures in paranthesis
            Customer customer1 = new Customer("Maria", "Dima", "Jernbanegade 24", "7100", "Vejle");
            customer1.addPhone("3232323");
            customer1.addPhone("7572547");
            Customer customer2 = new Customer("Alexandra", "Dima", "Jernbanegade 30", "7100", "Vejle");
            customer2.addPhone("3232323");
            customer2.addPhone("7572547");
            Customer customer3 = new Customer("George", "Marian", "Jernbanegade 30", "7100", "Vejle");
            customer3.addPhone("3232323");
            customer3.addPhone("7572547");

            // assign a viewbag property to the new Movie object
            ViewBag.Customer1 = customer1;
            ViewBag.Customer2 = customer2;
            ViewBag.Customer3 = customer3;

            return View();
        }


      

    

}
    }
