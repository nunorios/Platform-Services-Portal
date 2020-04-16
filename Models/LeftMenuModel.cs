using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Platform_Services_Portal.Models
{
    public class LeftMenuModel
    {
        [JsonPropertyName("Service")]
        public string ServiceName { get; set; }
        public IEnumerable<ServiceMenu> ServiceMenu { get; set; }

        public string Icon { get; set; }
        public override string ToString() => JsonSerializer.Serialize<LeftMenuModel>(this);

    }
}

