using Platform_Services_Portal.Models;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Platform_Services_Portal.Services
{
    public class JsonFileServices
    {
        public JsonFileServices()
        {
        }

        private string JsonFileName(string fileName)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", fileName);
        }
        private string JsonFileName(string customer, string directory, string serverNname)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", "Customers", customer, directory, serverNname + ".json");
        }

        private string getServerDirectoryPath(string customer, string directory)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", "Customers", customer, directory);
        }
        private string getCustomerDirectoryPath(string customer)
        {
            return Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Data", "Customers", customer);
        }


        public IEnumerable<Server> GetServer(string customer, string directory, string serverName)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName(customer, directory, serverName)))
            {
                return JsonSerializer.Deserialize<Server[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        public IEnumerable<Server> GetServerList(string customer, string directory, string serverName)
        {
            using (var jsonFileReader = File.OpenText(JsonFileName(customer, directory, serverName)))
            {
                return JsonSerializer.Deserialize<Server[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }

        public IEnumerable<Server> GetServerList(string customer, string directory)
        {
            string[] fileNames = Directory.GetFiles(getServerDirectoryPath(customer, "CurrentConfig"));
            string jSonRead = "[";
            for (int index = 0; index < fileNames.Length; index++)
            {
                StreamReader sf = File.OpenText(fileNames[index]);
                string s = sf.ReadToEnd();
                jSonRead += s.Substring(1, s.Length - 4);
                if (index != fileNames.Length - 1)
                {
                    jSonRead += ",";
                }
                else
                {
                    jSonRead += "]";
                }
            }


            FileStream fs = File.Create(getCustomerDirectoryPath(customer) + "\\listOfServers.json");
            fs.Close();
            using (StreamWriter sw = new StreamWriter(fs.Name))
            {
                sw.Write(jSonRead);
            };

            using (var jsonFileReader = File.OpenText(JsonFileName(customer, "", fs.Name.Replace(".json", ""))))
            {
                return JsonSerializer.Deserialize<Server[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
            }
        }
        public static string SimpliFyDataHour(System.DateTime dateTime)
        {
            string newDateTime = dateTime.ToShortDateString().Replace("/", "") + "_" + dateTime.ToShortTimeString().Replace(":", "");
            return newDateTime;
        }

        public string SetNewServerDSC(VmW_AddNewServerDSCModel newDSC)
        {
            try
            {
                FileStream fs = File.Create(getCustomerDirectoryPath(newDSC.Server.Customer) + "\\Scheduled" + "\\" + newDSC.Server.ServerName + "_" + newDSC.ChangeRecord.ChangeNumber + "_" + SimpliFyDataHour(newDSC.ChangeRecord.StartDate_Hour) + "_" + SimpliFyDataHour(newDSC.ChangeRecord.EndData_Hour) + ".json");
                fs.Close();
                using (StreamWriter sw = new StreamWriter(fs.Name))
                {
                    sw.Write(newDSC.Server.ToString());
                };
                return " A file name " + fs.Name + " was created with success.";
            }
            catch (System.Exception ex)
            {
                return ex.Message;
            }
        }


        public IEnumerable<LeftMenuModel> GetLeftMenu()
        {
            using (var jsonFileReader = File.OpenText(JsonFileName("LeftMenu.json")))
            {
                return JsonSerializer.Deserialize<LeftMenuModel[]>(jsonFileReader.ReadToEnd(),
                    new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true

                    });
            }
        }


    }
}