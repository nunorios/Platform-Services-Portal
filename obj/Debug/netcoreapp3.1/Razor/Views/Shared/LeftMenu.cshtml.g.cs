#pragma checksum "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Shared\LeftMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0bd170b80101ccd5eb9053aa6a4980e034d0554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_LeftMenu), @"mvc.1.0.view", @"/Views/Shared/LeftMenu.cshtml")]
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
#line 1 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\_ViewImports.cshtml"
using Platform_Services_Portal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\_ViewImports.cshtml"
using Platform_Services_Portal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0bd170b80101ccd5eb9053aa6a4980e034d0554", @"/Views/Shared/LeftMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b46b7ef092fd3716f3a2323bff6a264eb1a13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_LeftMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@" 

    <ul class=""nav"">

        <li class=""nav-item "">
            <a class=""nav-link"" href=""../../Home"">
                <i class=""material-icons"">dashboard</i>
                <p> Dashboard </p>
            </a>
        </li>
        <li class=""nav-item "">
            <!--<a class=""nav-link"" asp-area="""" asp-controller=""Home"" asp-action=""Create""></a>-->
            <a class=""nav-link"" href=""../../SubmitGitHubIssue"">
                <i class=""material-icons"">content_paste</i>
                <p> Request for Service </p>
            </a>
        </li>
        <li class=""nav-item "">
            <!--<a class=""nav-link"" asp-area="""" asp-controller=""Home"" asp-action=""Create""></a>-->
            <a class=""nav-link"" href=""../../ServerDefinition"">
                <i class=""material-icons"">content_paste</i>
                <p> Server Definition </p>
            </a>
        </li>
        <li class=""nav-item "">
            <!--<a class=""nav-link"" asp-area="""" asp-controller=""Home"" asp-action=""Cr");
            WriteLiteral(@"eate""></a>-->
            <a class=""nav-link"" href=""../../Server"">
                <i class=""material-icons"">content_paste</i>
                <p> Server List </p>
            </a>
        </li>

        <li class=""nav-item "">
            <a class=""nav-link"" href=""../../examples/calendar.html"">
                <i class=""material-icons"">content_paste</i>
                <p> Calendar </p>
            </a>
        </li>


    </ul>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591