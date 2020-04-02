using System.Text.Json;


namespace Platform_Services_Portal.Models
{
    public class VmW_AddNewDiskVM
    {
        public string Customer { get; set; }
        public string VMName { get; set; }
        public string DiskPersistency { get; set; }
        public string DiskType { get; set; }
        public int DiskSize { get; set; }
        public string CHGRecord { get; set; }
        public override string ToString() => JsonSerializer.Serialize<VmW_AddNewDiskVM>(this);
    }
}
