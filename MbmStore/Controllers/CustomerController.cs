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
            Customer firstCustomer = new Customer("Maria", "Dima", "20", "Jernbanegade 24", "7100", "Vejle");
            Customer secondCustomer = new Customer("Alexandra", "Dima", "20", "Jernbanegade 30", "7100", "Vejle");
            Customer thirdCustomer = new Customer("George", "Marian", "20", "Jernbanegade 30", "7100", "Vejle");

            /*
            List<string> PhoneNumbers = new List<string>()
            {
            PhoneNumbers.Add("2222222");
            PhoneNumbers.Add("2222222");
        }
        */


            // assign a viewbag property to the new Movie object
            ViewBag.FirstCustomer = firstCustomer;
            ViewBag.SecondCustomer = secondCustomer;
            ViewBag.ThirdCustomer = thirdCustomer;

            return View();
        }


      

    

}
    }
