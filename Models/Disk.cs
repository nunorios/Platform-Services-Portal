using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Platform_Services_Portal.Models
{
    public class Disk
    {
        [JsonPropertyName("Drive Letter")]
        public string DiskLabel { get; set; }
        [JsonPropertyName("Disk Size")]
        public int DiskSize { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Disk>(this);
    }
}
