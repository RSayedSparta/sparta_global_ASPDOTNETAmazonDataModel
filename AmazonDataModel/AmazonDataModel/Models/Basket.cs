using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Basket
    {
        private int BasketID;
        private string[] BasketItems;
        private Product product;

        public int BasketID1 { get => BasketID; set => BasketID = value; }
        public string[] BasketItems1 { get => BasketItems; set => BasketItems = value; }
        public Product Product { get => product; set => product = value; }
    }
}