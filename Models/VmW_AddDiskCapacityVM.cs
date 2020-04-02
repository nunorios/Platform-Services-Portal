using System.Text.Json;


namespace Platform_Services_Portal.Models
{
    public class VmW_AddDiskCapacityVM
    {
        public string Customer { get; set; }
        public string VMName { get; set; }
        public int DiskAddValue { get; set; }
        public string CHGRecord { get; set; }

        public override string ToString() => JsonSerializer.Serialize<VmW_AddDiskCapacityVM>(this);
    }
}
