using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Product
    {
        private int productID;
        private Supplier supplier;
        private Category category;
        private string productName;
        private string productDescription;
        private string picature;
        private double price;
    }
}