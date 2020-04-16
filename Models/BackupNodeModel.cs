using System.Text.Json;

namespace Platform_Services_Portal.Models
{
    public class BackupNodeModel
    {
        public Server Server { get; set; }
        public Server TSMServer { get; set; }
        public string BckNodeName { get; set; }

        public BackupNodeModel() { }
        public BackupNodeModel(Server Server)
        {
            this.Server = Server;
        }

        public override string ToString() => JsonSerializer.Serialize<BackupNodeModel>(this);

    }
}
