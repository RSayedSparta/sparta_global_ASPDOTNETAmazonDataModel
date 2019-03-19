using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Inventory
    {
        private int inventoryID;
        private Product product;
        private int quantity;

        public int InventoryID { get => inventoryID; set => inventoryID = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public Product Product { get => product; set => product = value; }
    }
}