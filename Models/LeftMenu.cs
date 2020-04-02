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
        public string SquadName { get; set; }
        public IEnumerable<SquadMenu> SquadMenu { get; set; }
        public override string ToString() => JsonSerializer.Serialize<LeftMenu>(this);
    }
}

