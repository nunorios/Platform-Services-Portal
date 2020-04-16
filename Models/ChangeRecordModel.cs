using System;

namespace Platform_Services_Portal.Models
{
    public class ChangeRecordModel
    {

        public string ChangeNumber { get; set; }
        public DateTime StartDate_Hour { get; set; }
        public DateTime EndData_Hour { get; set; }
        public string Summary { get; set; }
        public string Description { get; set; }
        public bool Unavailability { get; set; }
    }
}
