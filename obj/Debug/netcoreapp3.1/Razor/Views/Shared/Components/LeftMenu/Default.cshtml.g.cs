#pragma checksum "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ca8b48f5144b2b780b5c658491cfa4572547ec4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_LeftMenu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/LeftMenu/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca8b48f5144b2b780b5c658491cfa4572547ec4", @"/Views/Shared/Components/LeftMenu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b46b7ef092fd3716f3a2323bff6a264eb1a13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_LeftMenu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Platform_Services_Portal.Models.LeftMenuModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"card card-profile\">\r\n        <div class=\"card-avatar\">\r\n");
#nullable restore
#line 7 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
             if (@HttpContextAccessor.HttpContext.Session.GetString("Customer") != null)
            {
                string s = @HttpContextAccessor.HttpContext.Session.GetString("Customer");//(String)TempData["customer"];
                s = "/images/" + s.ToLower() + ".png";
                

#line default
#line hidden
#nullable disable
            WriteLiteral("<img class=\"img\"");
            BeginWriteAttribute("src", " src=", 584, "", 591, 1);
#nullable restore
#line 11 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
WriteAttributeValue("", 589, s, 589, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 12 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<ul class=\"nav\">\r\n    \r\n");
#nullable restore
#line 18 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
     foreach (var menu in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item \">\r\n            <a class=\"nav-link\" data-toggle=\"collapse\"");
            BeginWriteAttribute("href", " href=\"", 798, "\"", 823, 2);
            WriteAttributeValue("", 805, "#", 805, 1, true);
#nullable restore
#line 21 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
WriteAttributeValue("", 806, menu.ServiceName, 806, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <i class=\"material-icons\"> ");
#nullable restore
#line 22 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
                                      Write(menu.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                <p>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
               Write(menu.ServiceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <b class=\"caret\"></b>\r\n                </p>\r\n            </a>\r\n");
#nullable restore
#line 28 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
             if (menu.ServiceName != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"collapse\"");
            BeginWriteAttribute("id", " id=\"", 1125, "\"", 1147, 1);
#nullable restore
#line 30 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
WriteAttributeValue("", 1130, menu.ServiceName, 1130, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 32 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
                     foreach (var subMenu in menu.ServiceMenu)
                    {
                        string s = @HttpContextAccessor.HttpContext.Session.GetString("Customer");
                        if (s != null)
                        {
                            if (subMenu.Customers.Contains(s))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <ul class=\"nav\">\r\n                                    <li class=\"nav-item\">\r\n                                        <a class=\"nav-link\"");
            BeginWriteAttribute("href", " href=\"", 1672, "\"", 1693, 1);
#nullable restore
#line 42 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
WriteAttributeValue("", 1679, subMenu.Alias, 1679, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <i class=\"material-icons\">");
#nullable restore
#line 43 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
                                                                 Write(subMenu.Icon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\r\n                                            <span class=\"sidebar-normal\"> ");
#nullable restore
#line 44 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
                                                                     Write(subMenu.MenuName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n                                        </a>\r\n                                    </li>\r\n                                </ul>\r\n");
#nullable restore
#line 48 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"

                            }
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n");
#nullable restore
#line 53 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </li>\r\n");
#nullable restore
#line 55 "C:\Users\Admin\source\repos\Platform-Services-Portal\Views\Shared\Components\LeftMenu\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Platform_Services_Portal.Models.LeftMenuModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
