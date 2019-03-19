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

        public int DiscountID1 { get => DiscountID; set => DiscountID = value; }
        public string DiscountType1 { get => DiscountType; set => DiscountType = value; }
    }
}