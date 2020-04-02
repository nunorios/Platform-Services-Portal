using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Platform_Services_Portal.Models;
using Microsoft.AspNetCore.Hosting;

namespace Platform_Services_Portal.Services
{
    public class JsonFileServices
    {
        public JsonFileServices()
        {
        }

        private string JsonFileName()
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", "ServersList.json");
        }
        private string JsonFileName(string name)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", name + ".json");
        }

        public IEnumerable<ServerDefinition> GetServers()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName()))
            {
                return JsonSerializer.Deserialize<ServerDefinition[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true,
                        IgnoreNullValues = true
                    });
            }
        }
        

        public IEnumerable<ServerDefinition> GetServers(string name)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName(name)))
            {
                return JsonSerializer.Deserialize<ServerDefinition[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true

                    });
            }
        }

        public IEnumerable<Server> GetServer(string name)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName(name)))
            {
                return JsonSerializer.Deserialize<Server[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true

                    });
            }
        }
        public IEnumerable<Server> GetServerList()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName("Server100 - Copy")))
            {
                return JsonSerializer.Deserialize<Server[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true

                    });
            }
        }
        public IEnumerable<LeftMenu> GetLeftMenu()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName("LeftMenu")))
            {
                return JsonSerializer.Deserialize<LeftMenu[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true

                    });
            }
        }


    }
}