using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Supplier
    {
        private int supplierID;
        private Address address;
        private Product product;
        private string companyName;

        public int SupplierID { get => supplierID; set => supplierID = value; }
        public Address Address { get => address; set => address = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public Product Product { get => product; set => product = value; }
    }
}