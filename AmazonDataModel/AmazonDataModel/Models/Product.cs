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

        public int ProductID { get => productID; set => productID = value; }
        public Supplier Supplier { get => supplier; set => supplier = value; }
        public Category Category { get => category; set => category = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string ProductDescription { get => productDescription; set => productDescription = value; }
        public string Picature { get => picature; set => picature = value; }
        public double Price { get => price; set => price = value; }
    }
}