using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class OrderDetail
    {
        private int orderDetailsID;
        private Product product;
        private Shipper shipper;
        private Order order;
        private double price;
        private int quantity;
        private double total;

        public int OrderDetailsID { get => orderDetailsID; set => orderDetailsID = value; }
        public Product Product { get => product; set => product = value; }
        public double Price { get => price; set => price = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public double Total { get => total; set => total = value; }
        public Shipper Shipper { get => shipper; set => shipper = value; }
        public Order Order { get => order; set => order = value; }
    }
}