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
       List<string> phoneNumbers = new List<string>();
        DateTime birthDate;

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

        ///Age based on birthday

        DateTime BirthDate { get; set; }

        public int CalculateAgeWrong1(DateTime birthDate, DateTime now)
        {
            return new DateTime(now.Subtract(birthDate).Ticks).Year - 1;
        }

        public int CalculateAgeWrong2(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now < birthDate.AddYears(age))
                age--;

            return age;
        }

        public int CalculateAgeCorrect(DateTime birthDate, DateTime now)
        {
            int age = now.Year - birthDate.Year;

            if (now.Month < birthDate.Month || (now.Month == birthDate.Month && now.Day < birthDate.Day))
                age--;

            return age;
      
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
    }

}


