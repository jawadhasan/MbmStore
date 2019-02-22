using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Customer
    {
        // fields
       private string firstname;
       private string lastname;
       private int age;
       private string address;
       private string zip;
       private string city;
        private DateTime birthDate;
       List<string> phoneNumbers = new List<string>();
       List<Invoice> invoices = new List<Invoice>();

        // /////properties
        //Auto implemented property, in this case I won't need private string image url.
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        

        public string Address { get; set; }
        public string Zip { get; set; }
        public string City { get; set; }

        public List<string> PhoneNumbers {
            get { return phoneNumbers; }
        }

    

        public int Age{

            get {
            // code inside the get block of the Age property 
                DateTime now = DateTime.Now;
                int age = 0;
                age = now.Year - birthDate.Year;
                // calculate to see if the customer hasn’t had birthday yet // subtract one year if that is so 
                if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                {
                    age--;
                }

                return age;
            }
        }

        public DateTime BirthDate
        {
            set
            {
                birthDate = value;
                if ((DateTime.Now.Year - value.Year) > 120 || (DateTime.Now.Year - value.Year) < 0) 
                {
                    throw new Exception("Age not accepted");
                }
            }
            get {
                return birthDate;
            }
        }

        public List<Invoice> Invoices
        {
            get { return invoices; }
        }

        // constructors 

        public Customer(string firstname, string lastname, string address, string zip, string city)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Address= address;
            this.Zip = zip;
            this.City = city;
        }
        /// method AddPhone --to add or drag stuff
        public void addPhone(string phone)
        {
            PhoneNumbers.Add(phone);
        }

        /// method AddInvoice 
        public void addInvoice(Invoice invoice)
        {
            Invoices.Add(invoice);
        }

    }

    }




