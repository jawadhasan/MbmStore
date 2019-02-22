using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Invoice
    {
        // fields
        private decimal totalPrice;
        List<OrderItem> orderItems = new List<OrderItem>();

        // properties

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

        public List<OrderItem> OrderItems
        {
            get { return orderItems; }
        }

        public int InvoiceId
        {
            get;
            set;
        }

        public DateTime OrderDate
        {
            get;
            set;
        }

        public Customer Customer
        {
            get;
            set;
        }

        //contructors
       
        public Invoice(int invoiceId, DateTime orderDate, Customer customer)
        {
            this.InvoiceId = invoiceId;
            this.OrderDate = OrderDate;
            this.Customer = customer;
        }

        /// method AddPhone --to add or drag stuff
        public void addOrderItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
        }

    }
}