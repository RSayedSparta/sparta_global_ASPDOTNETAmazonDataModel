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

        public int HelpDeskID { get => helpDeskID; set => helpDeskID = value; }
        public string IssueMessage { get => issueMessage; set => issueMessage = value; }
    }
}