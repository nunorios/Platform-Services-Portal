#pragma checksum "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "140c2dae79773c9710fde159f19e1a855bbf4575"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Monitoring_Index), @"mvc.1.0.view", @"/Views/Monitoring/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"140c2dae79773c9710fde159f19e1a855bbf4575", @"/Views/Monitoring/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77b46b7ef092fd3716f3a2323bff6a264eb1a13d", @"/Views/_ViewImports.cshtml")]
    public class Views_Monitoring_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Platform_Services_Portal.Models.Server>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
  
    ViewData["Title"] = "";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content\">\r\n    <div class=\"container-fluid\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 10 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
             if (TempData["Success"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""alert alert-success"">
                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                        <i class=""material-icons"">close</i>
                    </button>
                    <span>
                        <b> Success - </b>  ");
#nullable restore
#line 17 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n");
#nullable restore
#line 20 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
             if (TempData["Error"] != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""alert alert-danger"">

                    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
                        <i class=""material-icons"">close</i>
                    </button>
                    <span>
                        <b> Error - </b>  ");
#nullable restore
#line 29 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                     Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n\r\n                </div>\r\n");
#nullable restore
#line 33 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header card-header-info card-header-icon"">
                        <div class=""card-icon"">
                            <i class=""material-icons"">assignment</i>
                        </div>
                        <h4 class=""card-title"">Server list</h4>
                    </div>
                    <div class=""card-body"">
                        <div class=""toolbar"">

                        </div>
                        <div class=""material-datatables"">
                            <table id=""datatables"" class=""table table-striped table-no-bordered table-hover"" cellspacing=""0"" width=""100%"" style=""width:100%"">
                                <thead>
                                    <tr>
                                        <th class=""sorting_asc"" tabindex=""0"" aria-controls=""datatables"" rowspan=""1"" colspan=""1"" style=""width: 111px;"" aria-sort=""ascending"" aria-label=""Name: activate ");
            WriteLiteral("to sort column descending\">\r\n                                            ");
#nullable restore
#line 51 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.ServerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 54 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 57 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Environment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 60 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.OperatingSystem));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                        </th>
                                        <th>Action</th>
                                    </tr>
                                </thead>
                                <tfoot>
                                    <tr>
                                        <th>
                                            ");
#nullable restore
#line 68 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.ServerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 71 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 74 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.Environment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>\r\n                                            ");
#nullable restore
#line 77 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                       Write(Html.DisplayNameFor(model => model.OperatingSystem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </th>\r\n                                        <th>Action</th>\r\n                                    </tr>\r\n                                </tfoot>\r\n                                <tbody>\r\n");
#nullable restore
#line 83 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 87 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.ServerName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 90 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 93 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Environment));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 96 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.OperatingSystem));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                            <td>\r\n                                                ");
#nullable restore
#line 99 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                           Write(Html.ActionLink("Agent Installation", "ITM", new { userAction = "SOAgentInstall", serverName = item.ServerName }, new { @class = "btn btn-info btn-sm right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                ");
#nullable restore
#line 100 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                           Write(Html.ActionLink("New situation", "ITM", new { userAction = "NewSituation", serverName = item.ServerName }, new { @class = "btn btn-info btn-sm right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                ");
#nullable restore
#line 101 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                           Write(Html.ActionLink("Modify threshold", "ITM", new { userAction = "ModifyThreshold", serverName = item.ServerName }, new { @class = "btn btn-info btn-sm right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                ");
#nullable restore
#line 102 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                           Write(Html.ActionLink("Subsystem agent installation", "ITM", new { userAction = "SubsysAgentInstall", serverName = item.ServerName }, new { @class = "btn btn-info btn-sm right" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 105 "C:\Users\Administrator\Source\Repos\Platform Services Portal\Views\Monitoring\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                </tbody>
                            </table>
                        </div>
                    </div>
                    <!-- end content-->
                </div>
                <!--  end card  -->
            </div>
            <!-- end col-md-12 -->
        </div>
        <!-- end row -->
    </div>
</div>


<!--   Core JS Files   -->
<script src=""../../assets/js/core/jquery.min.js""></script>
<script src=""../../assets/js/core/popper.min.js""></script>
<script src=""../../assets/js/core/bootstrap-material-design.min.js""></script>
<script src=""../../assets/js/plugins/perfect-scrollbar.jquery.min.js""></script>
<!-- Plugin for the momentJs  -->
<script src=""../../assets/js/plugins/moment.min.js""></script>
<!--  Plugin for Sweet Alert -->
<script src=""../../assets/js/plugins/sweetalert2.js""></script>
<!-- Forms Validations Plugin -->
<script src=""../../assets/js/plugins/jquery.validate.min.js""></script>
<!-- Plugin for the Wizard, full documentation he");
            WriteLiteral(@"re: https://github.com/VinceG/twitter-bootstrap-wizard -->
<script src=""../../assets/js/plugins/jquery.bootstrap-wizard.js""></script>
<!--	Plugin for Select, full documentation here: http://silviomoreto.github.io/bootstrap-select -->
<script src=""../../assets/js/plugins/bootstrap-selectpicker.js""></script>
<!--  Plugin for the DateTimePicker, full documentation here: https://eonasdan.github.io/bootstrap-datetimepicker/ -->
<script src=""../../assets/js/plugins/bootstrap-datetimepicker.min.js""></script>
<!--  DataTables.net Plugin, full documentation here: https://datatables.net/  -->
<script src=""../../assets/js/plugins/jquery.dataTables.min.js""></script>
<!--	Plugin for Tags, full documentation here: https://github.com/bootstrap-tagsinput/bootstrap-tagsinputs  -->
<script src=""../../assets/js/plugins/bootstrap-tagsinput.js""></script>
<!-- Plugin for Fileupload, full documentation here: http://www.jasny.net/bootstrap/javascript/#fileinput -->
<script src=""../../assets/js/plugins/jasny-bootstrap.min.");
            WriteLiteral(@"js""></script>
<!--  Full Calendar Plugin, full documentation here: https://github.com/fullcalendar/fullcalendar    -->
<script src=""../../assets/js/plugins/fullcalendar.min.js""></script>
<!-- Vector Map plugin, full documentation here: http://jvectormap.com/documentation/ -->
<script src=""../../assets/js/plugins/jquery-jvectormap.js""></script>
<!--  Plugin for the Sliders, full documentation here: http://refreshless.com/nouislider/ -->
<script src=""../../assets/js/plugins/nouislider.min.js""></script>
<!-- Include a polyfill for ES6 Promises (optional) for IE11, UC Browser and Android browser support SweetAlert -->
<script src=""https://cdnjs.cloudflare.com/ajax/libs/core-js/2.4.1/core.js""></script>
<!-- Library for adding dinamically elements -->
<script src=""../../assets/js/plugins/arrive.min.js""></script>
<!--  Google Maps Plugin    -->
<script src=""https://maps.googleapis.com/maps/api/js?key=YOUR_KEY_HERE""></script>
<!-- Chartist JS -->
<script src=""../../assets/js/plugins/chartist.min.js""></s");
            WriteLiteral(@"cript>
<!--  Notifications Plugin    -->
<script src=""../../assets/js/plugins/bootstrap-notify.js""></script>
<!-- Control Center for Material Dashboard: parallax effects, scripts for the example pages etc -->
<script src=""../../assets/js/material-dashboard.js?v=2.1.2"" type=""text/javascript""></script>
<!-- Material Dashboard DEMO methods, don't include it in your project! -->
<script src=""../../assets/demo/demo.js""></script>
<script>
    $(document).ready(function () {
        $().ready(function () {
            $sidebar = $('.sidebar');

            $sidebar_img_container = $sidebar.find('.sidebar-background');

            $full_page = $('.full-page');

            $sidebar_responsive = $('body > .navbar-collapse');

            window_width = $(window).width();

            fixed_plugin_open = $('.sidebar .sidebar-wrapper .nav li.active a p').html();

            if (window_width > 767 && fixed_plugin_open == 'Dashboard') {
                if ($('.fixed-plugin .dropdown').hasClass('sh");
            WriteLiteral(@"ow-dropdown')) {
                    $('.fixed-plugin .dropdown').addClass('open');
                }

            }

            $('.fixed-plugin a').click(function (event) {
                // Alex if we click on switch, stop propagation of the event, so the dropdown will not be hide, otherwise we set the  section active
                if ($(this).hasClass('switch-trigger')) {
                    if (event.stopPropagation) {
                        event.stopPropagation();
                    } else if (window.event) {
                        window.event.cancelBubble = true;
                    }
                }
            });

            $('.fixed-plugin .active-color span').click(function () {
                $full_page_background = $('.full-page-background');

                $(this).siblings().removeClass('active');
                $(this).addClass('active');

                var new_color = $(this).data('color');

                if ($sidebar.length != 0) {
             ");
            WriteLiteral(@"       $sidebar.attr('data-color', new_color);
                }

                if ($full_page.length != 0) {
                    $full_page.attr('filter-color', new_color);
                }

                if ($sidebar_responsive.length != 0) {
                    $sidebar_responsive.attr('data-color', new_color);
                }
            });

            $('.fixed-plugin .background-color .badge').click(function () {
                $(this).siblings().removeClass('active');
                $(this).addClass('active');

                var new_color = $(this).data('background-color');

                if ($sidebar.length != 0) {
                    $sidebar.attr('data-background-color', new_color);
                }
            });

            $('.fixed-plugin .img-holder').click(function () {
                $full_page_background = $('.full-page-background');

                $(this).parent('li').siblings().removeClass('active');
                $(this).parent('li').addCl");
            WriteLiteral(@"ass('active');


                var new_image = $(this).find(""img"").attr('src');

                if ($sidebar_img_container.length != 0 && $('.switch-sidebar-image input:checked').length != 0) {
                    $sidebar_img_container.fadeOut('fast', function () {
                        $sidebar_img_container.css('background-image', 'url(""' + new_image + '"")');
                        $sidebar_img_container.fadeIn('fast');
                    });
                }

                if ($full_page_background.length != 0 && $('.switch-sidebar-image input:checked').length != 0) {
                    var new_image_full_page = $('.fixed-plugin li.active .img-holder').find('img').data('src');

                    $full_page_background.fadeOut('fast', function () {
                        $full_page_background.css('background-image', 'url(""' + new_image_full_page + '"")');
                        $full_page_background.fadeIn('fast');
                    });
                }

               ");
            WriteLiteral(@" if ($('.switch-sidebar-image input:checked').length == 0) {
                    var new_image = $('.fixed-plugin li.active .img-holder').find(""img"").attr('src');
                    var new_image_full_page = $('.fixed-plugin li.active .img-holder').find('img').data('src');

                    $sidebar_img_container.css('background-image', 'url(""' + new_image + '"")');
                    $full_page_background.css('background-image', 'url(""' + new_image_full_page + '"")');
                }

                if ($sidebar_responsive.length != 0) {
                    $sidebar_responsive.css('background-image', 'url(""' + new_image + '"")');
                }
            });

            $('.switch-sidebar-image input').change(function () {
                $full_page_background = $('.full-page-background');

                $input = $(this);

                if ($input.is(':checked')) {
                    if ($sidebar_img_container.length != 0) {
                        $sidebar_img_container.f");
            WriteLiteral(@"adeIn('fast');
                        $sidebar.attr('data-image', '#');
                    }

                    if ($full_page_background.length != 0) {
                        $full_page_background.fadeIn('fast');
                        $full_page.attr('data-image', '#');
                    }

                    background_image = true;
                } else {
                    if ($sidebar_img_container.length != 0) {
                        $sidebar.removeAttr('data-image');
                        $sidebar_img_container.fadeOut('fast');
                    }

                    if ($full_page_background.length != 0) {
                        $full_page.removeAttr('data-image', '#');
                        $full_page_background.fadeOut('fast');
                    }

                    background_image = false;
                }
            });

            $('.switch-sidebar-mini input').change(function () {
                $body = $('body');

                $inpu");
            WriteLiteral(@"t = $(this);

                if (md.misc.sidebar_mini_active == true) {
                    $('body').removeClass('sidebar-mini');
                    md.misc.sidebar_mini_active = false;

                    $('.sidebar .sidebar-wrapper, .main-panel').perfectScrollbar();

                } else {

                    $('.sidebar .sidebar-wrapper, .main-panel').perfectScrollbar('destroy');

                    setTimeout(function () {
                        $('body').addClass('sidebar-mini');

                        md.misc.sidebar_mini_active = true;
                    }, 300);
                }

                // we simulate the window Resize so the charts will get updated in realtime.
                var simulateWindowResize = setInterval(function () {
                    window.dispatchEvent(new Event('resize'));
                }, 180);

                // we stop the simulation of Window Resize after the animations are completed
                setTimeout(function () {
   ");
            WriteLiteral(@"                 clearInterval(simulateWindowResize);
                }, 1000);

            });
        });
    });
</script>
<script>
    $(document).ready(function () {
        $('#datatables').DataTable({
            ""pagingType"": ""full_numbers"",
            ""lengthMenu"": [
                [10, 25, 50, -1],
                [10, 25, 50, ""All""]
            ],
            responsive: true,
            language: {
                search: ""_INPUT_"",
                searchPlaceholder: ""Search records"",
            }
        });

        var table = $('#datatable').DataTable();

        // Edit record
        table.on('click', '.edit', function () {
            $tr = $(this).closest('tr');
            var data = table.row($tr).data();
            alert('You press on Row: ' + data[0] + ' ' + data[1] + ' ' + data[2] + '\'s row.');
        });

        // Delete a record
        table.on('click', '.remove', function (e) {
            $tr = $(this).closest('tr');
            table.r");
            WriteLiteral("ow($tr).remove().draw();\r\n            e.preventDefault();\r\n        });\r\n\r\n        //Like record\r\n        table.on(\'click\', \'.like\', function () {\r\n            alert(\'You clicked on Like button\');\r\n        });\r\n    });\r\n</script>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Platform_Services_Portal.Models.Server>> Html { get; private set; }
    }
}
#pragma warning restore 1591
