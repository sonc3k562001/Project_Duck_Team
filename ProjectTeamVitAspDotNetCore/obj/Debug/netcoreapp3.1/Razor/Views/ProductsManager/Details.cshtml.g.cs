#pragma checksum "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "12c012dcba0164648f52baeb1bd6a92c848b31d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductsManager_Details), @"mvc.1.0.view", @"/Views/ProductsManager/Details.cshtml")]
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
#line 1 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c012dcba0164648f52baeb1bd6a92c848b31d7", @"/Views/ProductsManager/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e248320fd3eae94d921c736a1001947d916d09fe", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductsManager_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectTeamVitAspDotNetCore.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content pb-3\">\r\n    <div class=\"container-fluid h-100\">\r\n        <div class=\"card card-row card-secondary\">\r\n            <div class=\"card-header\">\r\n                <div style=\"text-align:center\">\r\n                    <h2> ");
#nullable restore
#line 13 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                    Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
            <div class=""card-body"">

                <dl class=""row"">
                    <dt class=""col-sm-2"">
                        Description:
                    </dt>
                    <dd class=""col-sm-10"">
                        ");
#nullable restore
#line 23 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Price:\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        $ ");
#nullable restore
#line 29 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                     Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Image:\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 35 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Image));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Size:\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 41 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Brand:\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 47 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Brand.BrandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Color:\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 53 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Color.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Diamond :\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 59 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Dim.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Category:\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 65 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Category.TypeName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Metal:\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 71 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Metal.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                    <dt class=\"col-sm-2\">\r\n                        Stone:\r\n                    </dt>\r\n                    <dd class=\"col-sm-10\">\r\n                        ");
#nullable restore
#line 77 "D:\Visual studio code\TeamVit\Project_Duck_Team-master\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\ProductsManager\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Stone.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </dd>\r\n                </dl>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "12c012dcba0164648f52baeb1bd6a92c848b31d710515", async() => {
                WriteLiteral("Back To List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectTeamVitAspDotNetCore.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
