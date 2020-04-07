using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Platform_Services_Portal.Models
{
    public class LeftMenu
    {
        [JsonPropertyName("Service")]
        public string ServiceName { get; set; }
        public IEnumerable<ServiceMenu> ServiceMenu { get; set; }
        public override string ToString() => JsonSerializer.Serialize<LeftMenu>(this);
    }
}

