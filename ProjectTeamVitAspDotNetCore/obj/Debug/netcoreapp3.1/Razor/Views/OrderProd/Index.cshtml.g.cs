#pragma checksum "D:\Visual studio code\TeamVit\Admin-eProject\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\OrderProd\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c292d99ed2773840a1c70084e707bb8283b27ed3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OrderProd_Index), @"mvc.1.0.view", @"/Views/OrderProd/Index.cshtml")]
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
#line 1 "D:\Visual studio code\TeamVit\Admin-eProject\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual studio code\TeamVit\Admin-eProject\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c292d99ed2773840a1c70084e707bb8283b27ed3", @"/Views/OrderProd/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e248320fd3eae94d921c736a1001947d916d09fe", @"/Views/_ViewImports.cshtml")]
    public class Views_OrderProd_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline col-12 mt-4 mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Visual studio code\TeamVit\Admin-eProject\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\OrderProd\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c292d99ed2773840a1c70084e707bb8283b27ed34216", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"/css/orderProd.css\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container\" style=\"background-color:white\">\r\n    <nav class=\"navbar navbar-light bg-white \">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c292d99ed2773840a1c70084e707bb8283b27ed35382", async() => {
                WriteLiteral(@"
            <div class=""col-10"">
                <input class=""form-control mr-sm-2"" style=""width:100%"" type=""search"" placeholder=""Customer name..."" aria-label=""Search"">
            </div>
            <div class=""col-2"">
                <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:100%"" type=""submit"">Search</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </nav>

    <div class=""mt-3"">
        <table class=""table bg-white"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Customer name</th>
                    <th scope=""col"">Email</th>
                    <th scope=""col"">Address</th>
                    <th scope=""col"">Order information</th>
                    <th scope=""col"">Order id</th>
                    <th scope=""col"">Order status</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">24");
            WriteLiteral(@"2346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'");
            WriteLiteral(@""" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                  ");
            WriteLiteral(@"      <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
          ");
            WriteLiteral(@"          <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
       ");
            WriteLiteral(@"         <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-p");
            WriteLiteral(@"rimary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
                <tr>
                    <th scope=""row"">1</th>
                    <td>Nguyên Giang Sơn</td>
                    <td>son@gmail.com</td>
                    <td>Gầm Cầu</td>
                    <td>
                        <button class=""btn btn-outline-success my-2 my-sm-0"" style=""width:80%"" onclick=""window.location.href='#popup1'"" type=""submit"">See description</button>
                    </td>
                    <td class=""text-primary"">242346324</td>
                    <td class=""text-primary"">Hoàn thành</td>
                </tr>
            </tbody>
        </table>
    </div>
</div>
<div id=""popup1"" class=""overlay"">
    <div class=""popup"">
        <h4 class=""mt-3 text-danger"">See description</h4>
        <a class=""close"" href=""#"">&times;</a>
        <div class=""content1"">
            <p>Product name : &nbsp; Asdhsjds </p>
            <p>Gem color : &nbsp; W");
            WriteLiteral("hite </p>\r\n            <p>Amount : &nbsp; 1 </p>\r\n            <p>Gemstone type : &nbsp; Hanh hihi </p>\r\n            <p>Description : &nbsp; ..... </p>\r\n        </div>\r\n    </div>\r\n</div> ");
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