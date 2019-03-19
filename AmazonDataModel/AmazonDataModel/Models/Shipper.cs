using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Shipper
    {
        private int shipperID;
        private Address address;
        private string companyName;

        public int ShipperID { get => shipperID; set => shipperID = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public Address Address { get => address; set => address = value; }
    }
}