#pragma checksum "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fa536cfce0d06d96218e6392e6ae4b802fe64eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_OrderDetails), @"mvc.1.0.view", @"/Views/Account/OrderDetails.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fa536cfce0d06d96218e6392e6ae4b802fe64eb", @"/Views/Account/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcdf0183c51389cb0648aa55e0fe996acd9221ea", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectTeamVitAspDotNetCore.Models.Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ListOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_LayoutProfile.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"content pb-3\">\r\n    <div class=\"container-fluid h-100\">\r\n        <div class=\"card card-row card-secondary\">\r\n            <div class=\"card-header\">\r\n                <div style=\"text-align:center\">\r\n                    <h2> ");
#nullable restore
#line 14 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                    Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                </div>
            </div>
            <div class=""card-body"">

                <dl class=""row"">
                    <dl class=""row"">
                        <dt class=""col-sm-2"">
                            Create Time:
                        </dt>
                        <dd class=""col-sm-10"">
                            ");
#nullable restore
#line 25 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(Html.DisplayFor(model => model.CreateTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n\r\n                        <dt class=\"col-sm-2\">\r\n                            Customer:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 32 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Address:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 38 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Birthday:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 44 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(Html.DisplayFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Gender:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 50 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Phone:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 56 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Zip Code:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 62 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(Html.DisplayFor(model => model.ZipCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Status:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 68 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            List Produt:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 74 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                             foreach (var product in ViewBag.products)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 76 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                                 Write(product.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("; &nbsp;&nbsp;</span>\r\n");
#nullable restore
#line 77 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </dd>\r\n                        <dt class=\"col-sm-2\">\r\n                            Total Price:\r\n                        </dt>\r\n                        <dd class=\"col-sm-10\">\r\n                            ");
#nullable restore
#line 83 "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\Account\OrderDetails.cshtml"
                       Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </dd>\r\n                    </dl>\r\n                </dl>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fa536cfce0d06d96218e6392e6ae4b802fe64eb11571", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectTeamVitAspDotNetCore.Models.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
