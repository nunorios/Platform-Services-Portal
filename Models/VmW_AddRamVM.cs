using System.Text.Json;

namespace Platform_Services_Portal.Models
{
    public class VmW_AddRamVM
    {
        public string Customer { get; set; }
        public string VMName { get; set; }
        public System.DateTime ScheduleDownTime { get; set; }
        public int RAMValue { get; set; }
        public string CHGRecord { get; set; }
        public override string ToString() => JsonSerializer.Serialize<VmW_AddRamVM>(this);
    }
}
