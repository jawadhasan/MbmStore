using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Product
    {
        // fields
        private string title;
        private decimal price;
    
        // properties
        public string Title
        {
            get { return title; } 
            set { title = value; }                   
        }

        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }

        public string ImageUrl
        {
            get;
            set;
        }

        // constructors 
        public Product()
        {
      
        }
        public Product(string title, decimal price, string imageUrl)
        {
            this.Title = title;
            this.Price = price;
            this.ImageUrl = imageUrl;
        }

    }
}