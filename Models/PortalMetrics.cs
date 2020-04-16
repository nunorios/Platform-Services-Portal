using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Platform_Services_Portal.Models
{
    public class PortalMetrics
    {
        //public DateTime Date { get; set; }
        public string MSG { get; set; }

        [Key]
        public int MsgId { get; set; }


       
    }
}
