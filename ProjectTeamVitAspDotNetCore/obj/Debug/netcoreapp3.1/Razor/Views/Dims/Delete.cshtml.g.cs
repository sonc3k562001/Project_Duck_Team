#pragma checksum "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c57e80228ff75546f7e1e155f16ceb73a9d8f719"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dims_Delete), @"mvc.1.0.view", @"/Views/Dims/Delete.cshtml")]
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
#line 1 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c57e80228ff75546f7e1e155f16ceb73a9d8f719", @"/Views/Dims/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcdf0183c51389cb0648aa55e0fe996acd9221ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Dims_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectTeamVitAspDotNetCore.Models.Dim>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h3>Are you sure you want to delete this?</h3>
<div>
    <section class=""content pb-3"">
        <div class=""container-fluid h-100"">
            <div class=""card card-row card-secondary"">
                <div class=""card-header"">
                    <div style=""text-align:center"">
                        <h2> ");
#nullable restore
#line 15 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                        Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
                <div class=""card-body"">

                    <dl class=""row"">
                        <dt class=""col-sm-5"">
                            Certify:
                        </dt>
                        <dd class=""col-sm-5"">
                            ");
#nullable restore
#line 25 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.Certify));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5\">\r\n                            Code:\r\n                        </dt>\r\n                        <dd class=\"col-sm-5\">\r\n                            ");
#nullable restore
#line 31 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.DimId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5\">\r\n                            Size:\r\n                        </dt>\r\n                        <dd class=\"col-sm-5\">\r\n                            ");
#nullable restore
#line 37 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.DimSize));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5\">\r\n                            Carat Of Diamond:\r\n                        </dt>\r\n                        <dd class=\"col-sm-5\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.DimCrt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5\">\r\n                            Total Amount Of Diamond In Item:\r\n                        </dt>\r\n                        <dd class=\"col-sm-5\">\r\n                            ");
#nullable restore
#line 49 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.DimAmt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5\">\r\n                            Weight Of Each Diamond(Grams):\r\n                        </dt>\r\n                        <dd class=\"col-sm-5\">\r\n                            ");
#nullable restore
#line 55 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.DimGm));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5\">\r\n                            Total Pcs Of Diamond In Item :\r\n                        </dt>\r\n                        <dd class=\"col-sm-5\">\r\n                            ");
#nullable restore
#line 61 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.DimPcs));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-5\">\r\n                            Rate Of Each Diamon:\r\n                        </dt>\r\n                        <dd class=\"col-sm-5\">\r\n                            ");
#nullable restore
#line 67 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
                       Write(Html.DisplayFor(model => model.DimRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n\r\n                    </dl>\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c57e80228ff75546f7e1e155f16ceb73a9d8f71910747", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c57e80228ff75546f7e1e155f16ceb73a9d8f71911014", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 78 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Dims\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.DimId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c57e80228ff75546f7e1e155f16ceb73a9d8f71912856", async() => {
                    WriteLiteral("Back To List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectTeamVitAspDotNetCore.Models.Dim> Html { get; private set; }
    }
}
#pragma warning restore 1591
