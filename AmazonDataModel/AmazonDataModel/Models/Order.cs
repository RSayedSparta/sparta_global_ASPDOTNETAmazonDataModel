using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Order
    {
        private int orderID;
        private Customer customer;
        private Payment payment;
        private int orderNumber;
        private DateTime orderDate;

        public int OrderID { get => orderID; set => orderID = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public Payment Payment { get => payment; set => payment = value; }
        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        public DateTime OrderDate { get => orderDate; set => orderDate = value; }
    }
}