#pragma checksum "C:\Users\son10\Downloads\Project_Duck_Team-QuynhUI (1)\Project_Duck_Team-QuynhUI\ProjectTeamVitAspDotNetCore\Views\View_pages\careers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da9e4ace8943e460435b84090f2c841be37e6405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_View_pages_careers), @"mvc.1.0.view", @"/Views/View_pages/careers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da9e4ace8943e460435b84090f2c841be37e6405", @"/Views/View_pages/careers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcdf0183c51389cb0648aa55e0fe996acd9221ea", @"/Views/_ViewImports.cshtml")]
    public class Views_View_pages_careers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/careers.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<enviroment>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "da9e4ace8943e460435b84090f2c841be37e64054044", async() => {
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
            WriteLiteral(@"
</enviroment>
<div class=""careers col-xs-12 col-md-12"">
    <section class=""careers_banner text-center col-xs-12 col-md-12"">
        <h2>Careers</h2>
    </section>
    <div class=""container"">
        <div class=""row"">
            <h3 class=""title"">CAREERS AT ASTLEY CLARKE</h3>
            <p>
                Astley Clarke is a British fine jewellery brand founded in London by Bec Astley Clarke MBE to celebrate design
                and colour in fine jewellery and to create a brand that represents all that is good and proper about British
                luxury. Astley Clarke’s personality is imbued with the wit and irreverence that captures the imagination of a
                new generation of luxury customers. We combine the grandest of ideas with an acute attention to the tiniest of
                details.
                <br>
                Based out of a little cobbled mews in W2, the head office houses the whole UK team from the design studio
                through to marketing and accounts. We m");
            WriteLiteral(@"ay be a small team but we are one that is dedicated to championing
                everything we love about Astley Clarke. Our current vacancies are listed below so if you would like to become a
                part of the Astley Clarke team please do not hesitate to get in touch at hr@astleyclarke.com.
            </p>

            <div>
                <a [routerLink]=""['/background']"">
                    <button type=""button"" class=""btn"">
                        OUR STORY
                    </button>
                </a>
            </div>
        </div>
    </div>
</div>");
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
