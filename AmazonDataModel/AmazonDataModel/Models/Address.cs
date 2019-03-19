using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Address
    {
        private string addressID;
        private string houseNumber;
        private string roadName;
        private string city;
        private string postCode;

         
        public string HouseNumber { get => houseNumber; set => houseNumber = value; }
        public string RoadName { get => roadName; set => roadName = value; }
        public string City { get => city; set => city = value; }
        public string PostCode { get => postCode; set => postCode = value; }
        public string AddressID { get => addressID; set => addressID = value; }
    }
}