using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie:Product
    {
        private string director;
        private string title;

        // properties
        public string Title
        {
           get { return title; } // read
          // set { title = value; } // write ----If set is commented I won't have the write and it will be read-only
        }
        /*
        public decimal Price 
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else {
                    price = value;
                }
            }
            get { return price; }
        }

        //Auto implemented property, in this case I won't need private string image url.
      /*  public string ImageUrl 
        {
            get;
            set;
        }
        */

        public string Director
        {
            get { return director; } // read
            set { director = value; } // write ----
        }

        // constructors are used within the MovieController
        public Movie(string title, decimal price)
        {
        }

        public Movie(string title, decimal price, string imageUrl, string director):
        base (title, price, imageUrl)
        {
            this.director = director;
        }
    }
}