#pragma checksum "C:\Users\ASUS\source\repos\Jewelly\Jewelly\Views\View_pages\delivery.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d51fa245582429b4c2f9eca2892217a84981aa6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_View_pages_delivery), @"mvc.1.0.view", @"/Views/View_pages/delivery.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\Jewelly\Jewelly\Views\_ViewImports.cshtml"
using Jewelly;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\Jewelly\Jewelly\Views\_ViewImports.cshtml"
using Jewelly.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d51fa245582429b4c2f9eca2892217a84981aa6c", @"/Views/View_pages/delivery.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acde5d9d09ec559b7be6e7ec2668bb492827a087", @"/Views/_ViewImports.cshtml")]
    public class Views_View_pages_delivery : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/delivery.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d51fa245582429b4c2f9eca2892217a84981aa6c3905", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d51fa245582429b4c2f9eca2892217a84981aa6c4174", async() => {
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
                WriteLiteral("\r\n");
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
<div class=""delivery col-xs-12 col-md-12"">
    <section class=""delivery_banner text-center col-xs-12 col-md-12"">
        <h2>Delivery</h2>
    </section>
    <div class=""container"">

        <section class=""col-xs-12 col-md-12"">
            <div>
                <h3 class=""bg-dark"">DELIVERY TIMES AND COSTS</h3>
                <h4>UK DELIVERY</h4>
                <span>
                    We offer <strong>free</strong> delivery to the UK on all orders. We also have ""Next Day"" and ""Same Day""
                    delivery options if you need your jewellery quicker than our standard 2-3 days delivery time. Select ""United
                    Kingdom""
                    in the drop-down below to view all of the options.
                </span>
            </div>

            <div>
                <h4>INTERNATIONAL DELIVERY</h4>
                <span>
                    We offer <strong>free</strong> international shipping
                    on all orders worldwide. Select your country be");
            WriteLiteral(@"low to view the delivery times.
                </span>
                <br>
                <select></select>
            </div>

            <div>
                <h4>NEXT DAY DELIVERY EXCLUSIONS</h4>
                <span>
                    Delivery to Channel Islands,
                    Isle of Man, Northern Ireland, Scilly Islands, the Scottish Highlands and Islands, and the following postcodes
                    with a two day delivery as standard: AB31-AB35, AB41-AB54, AB36-AB38, AB55-AB56, FK17-FK21, HS1-HS9, IV1-IV63,
                    KA27-KA28, KW0-KW14, KW15-KW17, PA20-PA78, PH15-PH18, PH19-PH29, PH32-PH33, PH45-PH48,
                    PH30-PH31, PH34-PH44, PH49-PH50, ZE1-ZE3.
                </span>
            </div>
        </section>

        <section class=""col-xs-12 col-md-12"">
            <h3 class=""bg-dark"">FURTHER INFORMATION</h3>
            <span>
                Orders may be subject to security checks, which can cause delays in the processing of orders. We");
            WriteLiteral(@" may need to
                contact you to carry out these security checks – if we are unable to reach you using the contact details
                provided it will delay the despatch of your order.

                Parcels will need to be signed for in person. Please ensure the delivery address is an address where you will be
                at the time of delivery (home or work). If someone is not present at the time of delivery, our courier company
                will leave a calling card and you will be able to reschedule your delivery for a more convenient time.

                Parcels with a business address chosen will be delivered to the designated delivery place at the chosen business
                address, not directly to the recipient.

                To check on the status of an order or verify delivery, please call <strong class=""link"">
                    +44 (0)20 7706
                    0060
                </strong>. Transactions are processed in pounds sterling.
      ");
            WriteLiteral(@"      </span>

        </section>

        <section class=""col-xs-12 col-md-12"">
            <h3 class=""bg-dark"">ORDERS OUTSIDE OF UK</h3>

        </section>
        <span>
            We are partnered with Global-e, who are a third-party service acting as your seller-on-record, allowing us to ship
            to destinations all around the world.
            After completing your Astley Clarke purchase, you will notice that your payment method is charged by **Global-e//
            Astley Clarke**, and your purchase
            is subject to Global-e's <strong class=""link"">terms and conditions</strong> and <strong class=""link"">
                privacy
                policy
            </strong> (which will be clearly presented in checkout before you place your order).
            You can <strong class=""link""> contact Global-e</strong> or write to them at 45 Leather Lane, London, EC1N 7TJ,
            United Kingdom.
            If you have placed an order for delivery outside of the UK, ");
            WriteLiteral(@"you can track the progress of your order here.
        </span>

        <section class=""col-xs-12 col-md-12"">
            <h3 class=""bg-dark"">RETURNS & EXCHANGES</h3>
            <span>
                All jewellery, excluding personalised items, returned within <strong>14 days</strong> of purchase is
                eligible for a refund or exchange.

                Unfortunately we are not able to refund or exchange items personalised with a photograph or engraving.

                We offer <strong>FREE</strong> returns for the following countries:

                Australia, Austria, Belgium, Bulgaria, Canada, Croatia, Cyprus, Czech Republic, Denmark, Estonia, Finland,
                France, Germany, Greece, Hong Kong, Hungary, Ireland, Italy, Latvia, Lithuania, Luxembourg, Malta, Netherlands,
                Poland, Portugal, Romania, Saudi Arabia, Singapore, Slovakia, Spain, Sweden, UAE, UK, USA.

                For more information about international returns, please visit <strong c");
            WriteLiteral("lass=\"link\">\r\n                    Returns &\r\n                    Exchanges.\r\n                </strong>\r\n            </span>\r\n        </section>\r\n    </div>\r\n</div>");
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
