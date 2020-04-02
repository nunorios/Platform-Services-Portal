using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Platform_Services_Portal.Models
{
    public class SquadMenu
    {
        public string Alias { get; set; }
        public IEnumerable<string> Customers { get; set; }
        public string MenuName { get; set; }
        public string Provider { get; set; }

        public override string ToString() => JsonSerializer.Serialize<SquadMenu>(this);
    }
}

