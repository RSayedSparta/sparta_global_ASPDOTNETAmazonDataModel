using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Admin
    {
        private int adminID;
        private string firstName;
        private string lastName;

        public int AdminID { get => adminID; set => adminID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
    }
}