#pragma checksum "C:\Users\son10\source\repos\ProjectTeamVitAspDotNetCore\Views\Shared\component\dropdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ca4cb1a6c84182ebaa0bc28ca186f40ac4136a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_component_dropdown), @"mvc.1.0.view", @"/Views/Shared/component/dropdown.cshtml")]
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
#line 1 "C:\Users\son10\source\repos\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\son10\source\repos\ProjectTeamVitAspDotNetCore\Views\_ViewImports.cshtml"
using ProjectTeamVitAspDotNetCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ca4cb1a6c84182ebaa0bc28ca186f40ac4136a5", @"/Views/Shared/component/dropdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e248320fd3eae94d921c736a1001947d916d09fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_component_dropdown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/dropdown.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ca4cb1a6c84182ebaa0bc28ca186f40ac4136a54014", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2ca4cb1a6c84182ebaa0bc28ca186f40ac4136a54281", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
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
            WriteLiteral(@"
<div class=""dropdown_content col-xs-12 col-md-12"">
    <div class=""dropdown_content-left col-xs-2 col-md-2"">
        <ul class=""col-xs-12 col-md-12"">
            <li><a [routerLink]=""['/']"">Celestial Collection</a></li>
            <li><a [routerLink]=""['/']"">Solstice Collection</a></li>
            <li><a [routerLink]=""['/']"">Biography Collection</a></li>
            <li><a [routerLink]=""['/']"">Interstellar Collection</a></li>
            
            <li><a [routerLink]=""['/']"">View All New Arrivals</a></li>
            <li><a [routerLink]=""['/']"">View All Jewellery</a></li>
        </ul>
    </div>
    <div class=""dropdown_content-right align-items-center col-xs-10 col-md-10"">
        <div class=""d-flex justify-content-center align-items-center col-xs-12 col-md-12"">
            <div class=""d-flex flex-column justify-content-center align-items-center text-center col-xs-3 col-md-3"">
                <a [routerLink]=""['/']"">
                    <img src=""https://www.astleyclarke.com/media/cms/pronav/2021-01-0");
            WriteLiteral("6/gifs/new-arrivals.gif\"");
            BeginWriteAttribute("alt", " alt=\"", 1131, "\"", 1137, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h3>The New Diamond Locket</h3>
                </a>
            </div>
            <div class=""d-flex flex-column justify-content-center align-items-center text-center col-xs-3 col-md-3"">
                <a [routerLink]=""['/']"">
                    <img src=""https://www.astleyclarke.com/media/catalog/product/cache/1/image/300x300/9df78eab33525d08d6e5fb8d27136e95/d/e/des10572v1_a/Astley-Clarke-Celestial-Chain-Bracelet-47001YNOB.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 1596, "\"", 1627, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h3>Celestial Chain Bracelet</h3>
                </a>
            </div>
            <div class=""d-flex flex-column justify-content-center align-items-center text-center col-xs-3 col-md-3"">
                <a [routerLink]=""['/']"">
                    <img src=""https://www.astleyclarke.com/media/catalog/product/cache/1/image/300x300/9df78eab33525d08d6e5fb8d27136e95/4/7/47009ynor_a/Astley-Clarke-Celestial-Ring-47009YNOR.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 2077, "\"", 2108, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    <h3>Celestial Ring</h3>
                </a>
            </div>
            <div class=""d-flex flex-column justify-content-center align-items-center text-center col-xs-3 col-md-3"">
                <a [routerLink]=""['/']"">
                    <img src=""https://www.astleyclarke.com/media/catalog/product/cache/1/image/300x300/9df78eab33525d08d6e5fb8d27136e95/4/7/47007ynor_a/Astley-Clarke-Celestial-Compass-Ring-47007YNOR.jpg""");
            BeginWriteAttribute("alt", "\n                         alt=\"", 2556, "\"", 2587, 0);
            EndWriteAttribute();
            WriteLiteral(">\n                    <h3>Celestial Compass Ring</h3>\n                </a>\n            </div>\n        </div>\n    </div>\n</div>");
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
