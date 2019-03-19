using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AmazonDataModel.Models
{
    public class MaintenanceLog
    {
        private int MaintenanceID;
        private DateTime MaintenanceDate;
        private DateTime MaintenanceTime;

        public int MaintenanceID1 { get => MaintenanceID; set => MaintenanceID = value; }
        public DateTime MaintenanceDate1 { get => MaintenanceDate; set => MaintenanceDate = value; }
        public DateTime MaintenanceTime1 { get => MaintenanceTime; set => MaintenanceTime = value; }
    }
}