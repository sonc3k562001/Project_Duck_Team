#pragma checksum "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e50c9924cdbcabadfc102929be6046b5ebc2b19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
#line 1 "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e50c9924cdbcabadfc102929be6046b5ebc2b19", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e248320fd3eae94d921c736a1001947d916d09fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\Dashboard\Index.cshtml"
   Layout = "_AdminLayout"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.9.1/jquery.min.js""></script>
<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $.ajax({
            type: 'GET',
            dataType: ""json"",
            contentType: ""application/json"",
            url: '/api/product/findall',
            success: function (result) {
                google.charts.load('current', {
                    'packages': ['corechart']
                });
                google.charts.setOnLoadCallback(function () {
                    BarChart(result);
                });
            }
        });

        function BarChart(result) {
            var data = new google.visualization.DataTable();
            data.addColumn('string', 'time');
            data.addColumn('number', 'money');

            var dataArray = [];
            $.each(result, function (i, obj) {
                dataArray.push([obj.time, obj.mon");
            WriteLiteral(@"ey]);
            });

            data.addRows(dataArray);

            var barchart_options = {
                title: 'Barchart: Monthly revenue',
                width: 550,
                height: 400
            };

            var barchar = new google.visualization.BarChart(document
                .getElementById('barchar_div'));
            barchar.draw(data, barchart_options);
        }

    });

</script>

<script type=""text/javascript"">
    $(document).ready(function () {
        $.ajax({
            type: 'GET',
            dataType: ""json"",
            contentType: ""application/json"",
            url: '/api/product/findyear',
            success: function (result) {
                google.charts.load('current', {
                    'packages': ['corechart']
                });
                google.charts.setOnLoadCallback(function () {
                    PieChart(result);
                });
            }
        });

        function PieChart(result) {
            var data = new google.visu");
            WriteLiteral(@"alization.DataTable();
            data.addColumn('string', 'time');
            data.addColumn('number', 'money');

            var dataArray = [];
            $.each(result, function (i, obj) {
                dataArray.push([obj.time, obj.money]);
            });

            data.addRows(dataArray);
            ///
            var piechart_options = {
                title: 'Pie Chart: Sales rate for the past 3 years',
                width: 550,
                height: 400,

            };
            var piechart = new google.visualization.PieChart(document
                .getElementById('piechart_div'));
            piechart.draw(data, piechart_options);

        }

    });

</script>
<div class=""col-lg-12"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <div class="" title-header"" style=""background-color: white;border:1px solid #a59b9b;border-radius:15px"">
                <div class=""row"">
                    <div class=""mt-4 pl-5"">
                        <h6>Total product</h6>
    ");
            WriteLiteral(@"                </div>
                    <div class=""col-lg-12 mt-2 mb-3"">
                        <div class=""row"">
                            <div class=""col-lg-6 mt-2"">
                                <i class=""fas fa-chart-pie pt-2 pl-5"" style=""color:green;font-size:30px""></i>
                            </div>
                            <div class=""col-lg-6 mt-2 pr-3"">
                                <div class=""btn btn-success"" style=""margin-left:90px"">");
#nullable restore
#line 106 "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\Dashboard\Index.cshtml"
                                                                                 Write(ViewBag.totalProduct);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class="" title-header"" style=""background-color: white;border:1px solid #a59b9b;border-radius:15px"">
                <div class=""row"">
                    <div class=""mt-4 pl-5"">
                        <h6>Total number of customers</h6>
                    </div>
                    <div class=""col-lg-12 mt-2 mb-3"">
                        <div class=""row"">
                            <div class=""col-lg-6 mt-2"">
                                <i class=""far fa-chart-bar pt-2 pl-5"" style=""color:red;font-size:30px""></i>
                            </div>
                            <div class=""col-lg-6 mt-2"">
                                <div class=""btn btn-danger"" style=""margin-left:90px"">");
#nullable restore
#line 125 "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\Dashboard\Index.cshtml"
                                                                                Write(ViewBag.totalUser);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-4"">
            <div class=""title-header"" style=""background-color: white;border:1px solid #a59b9b;border-radius:15px"">
                <div class=""row"">
                    <div class=""mt-4 pl-5"">
                        <h6>Total number of orders</h6>
                    </div>
                    <div class=""col-lg-12 mt-2 mb-3"">
                        <div class=""row"">
                            <div class=""col-lg-6 mt-2"">
                                <i class=""fas fa-chart-line pt-2 pl-5"" style=""color:blue;font-size:30px""></i>
                            </div>
                            <div class=""col-lg-6 mt-2"">
                                <div class=""btn btn-primary"" style=""margin-left:90px"">");
#nullable restore
#line 144 "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\Dashboard\Index.cshtml"
                                                                                 Write(ViewBag.totalOrder);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<br />
<br />
<br />
<div class=""col-lg-12"">
    <div class=""row"">
        <div class=""col-lg-6"">
            <div id=""barchar_div"" style=""border:1px solid #ccc""></div>
        </div>
        <div class=""col-lg-6"">
            <div id=""piechart_div"" style=""border:1px solid #ccc""></div>
        </div>
    </div>
</div>




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
