using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class BillingAddress
    {
        private int BillingID;
        private Address address;
        private Customer customer;

        public int BillingID1 { get => BillingID; set => BillingID = value; }
        public Address Address { get => address; set => address = value; }
        public Customer Customer { get => customer; set => customer = value; }
    }
}