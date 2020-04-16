using System.Collections.Generic;
using System.Text.Json;

namespace Platform_Services_Portal.Models
{
    public class ServiceMenu
    {
        public string Alias { get; set; }
        public IEnumerable<string> Customers { get; set; }
        public string MenuName { get; set; }
        //public string Provider { get; set; }
        public string Icon { get; set; }

        public override string ToString() => JsonSerializer.Serialize<ServiceMenu>(this);
    }
}

