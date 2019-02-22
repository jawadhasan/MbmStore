using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class OrderItem
    {
        private decimal totalPrice;
        // properties

        public int OrderItemId
        {
            get;
            set;
        }

        public int ProductId
        {
            get;
            set;
        }

        public Product Product
        {
            get;
            set;
        }

        public int Quantity
        {
            get;
            set;
        }

        public decimal TotalPrice
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    totalPrice = value;
                }
            }
        }

        ///Constructor for OrderItem
        public OrderItem()
        {
        }
        public OrderItem(Product product, int quantity)
        {
            this.Product = product;
            this.Quantity = quantity;
        }

    }
}