using System.Text.Json;
using System.Text.Json.Serialization;

namespace Platform_Services_Portal.Models
{
    public class ServerDefinition
    {
        public string Name { get; set; }
        public string OperatingSystem { get; set; }

        [JsonPropertyName("Server Type")]
        public string ServerType { get; set; }
        public override string ToString() => JsonSerializer.Serialize<ServerDefinition>(this);
    }
}
