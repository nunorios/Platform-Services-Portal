using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Platform_Services_Portal.Models
{
    public class Server
    {
        [JsonPropertyName("Name")]
        public string ServerName { get; set; }
        public string OperatingSystem { get; set; }
        public string Type { get; set; }

        public string Environment { get; set; }
        public string Customer { get; set; }
        public int Memory { get; set; }
        public int CPU { get; set; }
        public List<Disk> Disks { get; set; }
        //public IEnumerable<string> Software { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Server>(this);
    }
}
