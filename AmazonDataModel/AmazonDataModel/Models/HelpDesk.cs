using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class HelpDesk
    {
        private int helpDeskID;
        private string issueMessage;
        private Customer customer;

        public int HelpDeskID { get => helpDeskID; set => helpDeskID = value; }
        public string IssueMessage { get => issueMessage; set => issueMessage = value; }
        public Customer Customer { get => customer; set => customer = value; }
    }
}