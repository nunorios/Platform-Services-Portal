#pragma checksum "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9e37dc39eb030da09e137bae44102d400916e70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Server_Details), @"mvc.1.0.view", @"/Views/Server/Details.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\_ViewImports.cshtml"
using Platform_Services_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\_ViewImports.cshtml"
using Platform_Services_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9e37dc39eb030da09e137bae44102d400916e70", @"/Views/Server/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b46b7ef092fd3716f3a2323bff6a264eb1a13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Server_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Platform_Services_Portal.Models.Server>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card"">
                    <div class=""card-header card-header-info card-header-icon"">
                        <div class=""card-icon"">
                            <i class=""material-icons"">assignment</i>
                        </div>
                        <h4 class=""card-title"">Server ");
#nullable restore
#line 16 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                                 Write(Html.DisplayFor(model => model.ServerName));

#line default
#line hidden
#nullable disable
            WriteLiteral(" current state</h4>\r\n                    </div>\r\n                    <div class=\"card-body\">\r\n                        <dl class=\"row\">\r\n                            <dt class=\"col-6\">\r\n                                ");
#nullable restore
#line 21 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.ServerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-6\">\r\n                                ");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayFor(model => model.ServerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-6\">\r\n                                ");
#nullable restore
#line 27 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-6\">\r\n                                ");
#nullable restore
#line 30 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-6\">\r\n                                ");
#nullable restore
#line 33 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.OperatingSystem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-6\">\r\n                                ");
#nullable restore
#line 36 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayFor(model => model.OperatingSystem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-6\">\r\n                                ");
#nullable restore
#line 39 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Environment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-6\">\r\n                                ");
#nullable restore
#line 42 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Environment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-6\">\r\n                                ");
#nullable restore
#line 45 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.Memory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-6\">\r\n                                ");
#nullable restore
#line 48 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Memory));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dd>\r\n                            <dt class=\"col-6\">\r\n                                ");
#nullable restore
#line 51 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayNameFor(model => model.CPU));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </dt>\r\n                            <dd class=\"col-6\">\r\n                                ");
#nullable restore
#line 54 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                           Write(Html.DisplayFor(model => model.CPU));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                            </dd>
                        </dl>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header card-header-info card-header-icon"">
                        <div class=""card-icon"">
                            <i class=""material-icons"">assignment</i>
                        </div>
                        <h4 class=""card-title"">Disk details</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""table-responsive"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th class=""text-center"">#</th>
                                        <th>Disk Label</th>
                                        <th>Disk Size</th>
                                    </tr>
                                </thead>
                             ");
            WriteLiteral("   <tbody>\r\n");
#nullable restore
#line 77 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                      
                                        for (int index = 0; index < Model.Disks.Count; index++)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td class=\"text-center\">");
#nullable restore
#line 81 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                                                   Write(index);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 82 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                               Write(Html.DisplayFor(model => @Model.Disks[index].DiskLabel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 83 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                               Write(Html.DisplayFor(model => @Model.Disks[index].DiskSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            </tr>\r\n");
#nullable restore
#line 85 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                        }
                                    

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                </div>
                <div class=""card"">

                    <div class=""card-footer text-center"">
                        <div class=""form-check mr-auto"">
                        </div>
                        <button class=""btn btn-sm"">
                            <span class=""btn-label"">
                                <i class=""material-icons"">keyboard_arrow_left</i>
                            </span>
                            ");
#nullable restore
#line 101 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                       Write(Html.ActionLink("Back to list", "Index", "Server", null, new { style = "color: white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </button>
                        <button class=""btn btn-info btn-sm"">
                            <span class=""btn-label"">
                                <i class=""material-icons"">get_app</i>
                            </span>
                            ");
#nullable restore
#line 107 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                       Write(Html.ActionLink("Export", "Export", "Server", null, new { style = "color: white", target = "_blank" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </button>
                        <button class=""btn btn-warning btn-sm"">
                            <span class=""btn-label"">
                                <i class=""material-icons"">warning</i>
                            </span>
                            ");
#nullable restore
#line 113 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                       Write(Html.ActionLink("Change config", "Edit", "Server", null, new { style = "color: white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </button>\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"card\">\r\n");
#nullable restore
#line 120 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                  if (ViewBag.Differences != null)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <div class=""card-header card-header-warning card-header-icon"">
                            <div class=""card-icon"">
                                <i class=""material-icons"">warning</i>
                            </div>
                            <h4 class=""card-title"">New desired state</h4>
                        </div>
                        <div class=""card-body"">
                            <div class=""table-responsive"">
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th>Element</th>
                                            <th>Current value</th>
                                            <th>New value</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 139 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                         foreach (var dif in ViewBag.Differences)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n\r\n                                                <td class=\"text-left\">");
#nullable restore
#line 143 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                                                 Write(dif.MemberPath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"text-right\">");
#nullable restore
#line 144 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                                                  Write(dif.Value1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td class=\"text-danger text-right\">");
#nullable restore
#line 145 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                                                              Write(dif.Value2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                            </tr>\r\n");
#nullable restore
#line 148 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </tbody>\r\n                                    <tfoot>\r\n\r\n                                    </tfoot>\r\n                                </table>\r\n");
#nullable restore
#line 154 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                 if (ViewBag.Differences.Count > 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""card-footer text-right"">
                                <div class=""form-check mr-auto"">
                                    <button class=""btn btn-success btn-sm"">
                                        <span class=""btn-label"">
                                            <i class=""material-icons"">check</i>
                                        </span>
                                        ");
#nullable restore
#line 162 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                   Write(Html.ActionLink("Discard changes", "Index",  new { userAction = "Discard" }, new { style = "color: white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </button>
                                    <button class=""btn btn-danger btn-sm"">
                                        <span class=""btn-label"">
                                            <i class=""material-icons"">close</i>
                                        </span>
                                        ");
#nullable restore
#line 168 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                   Write(Html.ActionLink("Commit changes", "Index", "/VmW_AddNewServerDSC",  new { userAction = "Commit" }, new { style = "color: white" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </button>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 172 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 175 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Server\Details.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Platform_Services_Portal.Models.Server> Html { get; private set; }
    }
}
#pragma warning restore 1591
