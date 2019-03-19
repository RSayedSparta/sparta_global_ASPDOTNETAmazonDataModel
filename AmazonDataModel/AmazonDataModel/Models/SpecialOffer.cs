using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class SpecialOffer
    {
        private int DiscountID;
        private string DiscountType;
        private Product product;

        public int DiscountID1 { get => DiscountID; set => DiscountID = value; }
        public string DiscountType1 { get => DiscountType; set => DiscountType = value; }
        public Product Product { get => product; set => product = value; }
    }
}