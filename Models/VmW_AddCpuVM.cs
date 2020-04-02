using System.Text.Json;

namespace Platform_Services_Portal.Models
{
    public class VmW_AddCpuVM
    {
        public string Customer { get; set; }
        public string VMName { get; set; }
        public System.DateTime ScheduleDownTime { get; set; }
        public int CPUValue { get; set; }
        public string CHGRecord { get; set; }
        public override string ToString() => JsonSerializer.Serialize<VmW_AddCpuVM>(this);
    }
}
