using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class OrderHistory
    {
        private int OrderHistoryID;
        private double totalCost;
        private Customer customer;
        private OrderDetail orderDetail;

        public int OrderHistoryID1 { get => OrderHistoryID; set => OrderHistoryID = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public OrderDetail OrderDetail { get => orderDetail; set => orderDetail = value; }
    }
}