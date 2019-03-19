using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Category
    {
        private int categoryID;
        private string categoryDescription;
        private Product product;

        public int CategoryID { get => categoryID; set => categoryID = value; }
        public string CategoryDescription { get => categoryDescription; set => categoryDescription = value; }
        public Product Product { get => product; set => product = value; }
    }
}