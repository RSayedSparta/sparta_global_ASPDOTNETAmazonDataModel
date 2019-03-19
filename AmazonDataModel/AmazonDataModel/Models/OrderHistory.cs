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

        public int OrderHistoryID1 { get => OrderHistoryID; set => OrderHistoryID = value; }
        public double TotalCost { get => totalCost; set => totalCost = value; }
    }
}