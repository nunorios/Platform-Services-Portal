using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Platform_Services_Portal.Models;
using Platform_Services_Portal.Services;
using ObjectsComparer;

namespace Platform_Services_Portal.Controllers
{
    public class VmW_AddNewServerDSCController : Controller
    {

        public JsonFileServices JsonService;
        public Server Server { get; set; }

        IEnumerable<Difference> differences;

        VmW_AddNewServerDSCModel NewDSC { get; set; }

        public IActionResult Index()
        {
            Server = getServerFromSession();
            differences = getDifferencesFromSession();
            ChangeRecordModel changeRecord = new ChangeRecordModel();
            NewDSC = new VmW_AddNewServerDSCModel(Server, differences);
            //changeRecord.Summary = "New DSC for server" + NewDSC.Server.ServerName;
            //string changesToImplement = "";
            //foreach (var item in NewDSC.Differences)
            //{
            //    changesToImplement += "<b>"+item.MemberPath +"</b>";
            //    //changesToImplement += " " + item.Value1
            //}
            //changeRecord.Description = "new DSC\n" + NewDSC.Server.ToString() + "\n\n" + "List of changes \n"+ changesToImplement;
            //NewDSC.ChangeRecord = changeRecord;
            return View();
        }

        public IActionResult Submit(VmW_AddNewServerDSCModel _NewDSC)
        {
            JsonService = new JsonFileServices();
            ChangeRecordModel changeRecord = new ChangeRecordModel();
            changeRecord = _NewDSC.ChangeRecord;
            NewDSC = new VmW_AddNewServerDSCModel();
            NewDSC.Server = getServerFromSession();
            NewDSC.ChangeRecord = changeRecord;
            JsonService.SetNewServerDSC(NewDSC);
            NewDSC.ChangeRecord.ChangeNumber = "";
            return Redirect(nameof(Index));

        }
        public IEnumerable<Difference> getDifferencesFromSession()
        {
            var str = HttpContext.Session.GetString("differences");
            differences = JsonConvert.DeserializeObject<IEnumerable<Difference>>(str);
            return differences;
        }
        public Server getServerFromSession()
        {
            var str = HttpContext.Session.GetString("Server");
            Server = JsonConvert.DeserializeObject<Server>(str);
            return Server;
        }
    }
}