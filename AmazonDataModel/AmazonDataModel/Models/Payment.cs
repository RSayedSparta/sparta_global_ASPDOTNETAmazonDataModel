﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class Payment
    {
        private int paymentID;
        private string paymentType;

        public int PaymentID { get => paymentID; set => paymentID = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
    }
}