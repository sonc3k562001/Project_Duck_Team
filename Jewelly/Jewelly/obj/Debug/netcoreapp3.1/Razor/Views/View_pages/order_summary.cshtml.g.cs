#pragma checksum "C:\Users\ASUS\source\repos\Jewelly\Jewelly\Views\View_pages\order_summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c54344fcf14806c11c2894cd73b9cb9618b65e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_View_pages_order_summary), @"mvc.1.0.view", @"/Views/View_pages/order_summary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c54344fcf14806c11c2894cd73b9cb9618b65e4", @"/Views/View_pages/order_summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"acde5d9d09ec559b7be6e7ec2668bb492827a087", @"/Views/_ViewImports.cshtml")]
    public class Views_View_pages_order_summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/order-summary.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c54344fcf14806c11c2894cd73b9cb9618b65e44349", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c54344fcf14806c11c2894cd73b9cb9618b65e44618", async() => {
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
<div class=""order col-xs-12 col-md-12"">
    <div class=""container"">
        <div class=""row"">
            <section class=""order_summary col-xs-12 col-md-12"">
                <h2>Order Summary</h2>
                <table class=""table table-responsive align-middle text-center"">
                    <thead>
                        <tr>
                            <th>Product Image</th>
                            <th>Product Name</th>
                            <th>Product Price</th>
                            <th>Product Quantity</th>
                            <th>Product Total</th>
                        </tr>
                    </thead>

                    <tbody>
                        <tr>
                            <td>
                                <a [routerLink]=""['/']"">
                                    <img class=""col-xs-12 col-md-12""
                                         src=""https://www.astleyclarke.com/media/catalog/product/cache/1/thumbnail/170x/9df78eab33525d");
            WriteLiteral(@"08d6e5fb8d27136e95/4/6/46038yrdr_a/Astley-Clarke-Ruby-Stacking-Ring-46038YRDR60.jpg"">
                                </a>
                            </td>
                            <td>
                                <ul>
                                    <li>RUBY STACKING RING</li>
                                    <li>Size: L</li>
                                </ul>
                            </td>
                            <td>
                                <span>₫10,618,373</span>
                            </td>
                            <td>1</td>
                            <td>₫10,618,373</td>
                        </tr>
                    </tbody>

                    <tfoot>
                        <tr class=""total_row"">
                            <td colspan=""3"" class=""text-end"">TOTAL</td>
                            <td></td>
                            <td class=""total_row-price"">₫23,360,421</td>
                        </tr>
                    </tfo");
            WriteLiteral("ot>\r\n                </table>\r\n            </section>\r\n\r\n            <section class=\"order_form col-xs-12 col-md-12\">\r\n                <div class=\"left col-xs-6 col-md-6\">\r\n                    <h2>BILLING ADDRESS</h2>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c54344fcf14806c11c2894cd73b9cb9618b65e48892", async() => {
                WriteLiteral(@"
                        <div class=""form-group"">
                            <label for=""firstName"">First Name</label>
                            <input type=""text"" class=""form-controls"" id=""firstName"" name=""firstName"">
                        </div>
                        <div class=""form-group"">
                            <label for=""lastName"">Last Name</label>
                            <input type=""text"" class=""form-controls"" id=""lastName"" name=""lastName"">
                        </div>
                        <div class=""form-group"">
                            <label for=""email"">Email</label>
                            <input type=""email"" class=""form-controls"" id=""email"" name=""email"">
                        </div>
                        <div class=""form-group"">
                            <label for=""country"">Country</label>
                            <select class=""form-controls"" id=""country"" name=""country"">
                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c54344fcf14806c11c2894cd73b9cb9618b65e410179", async() => {
                    WriteLiteral("Vietnam");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""form-group"">
                            <label for=""address1"">Address 1</label>
                            <input type=""text"" class=""form-controls"" id=""address1"" name=""address1"">
                        </div>
                        <div class=""form-group"">
                            <label for=""address2"">Address 2</label>
                            <input type=""text"" class=""form-controls"" id=""address2"" name=""address2"">
                        </div>
                        <div class=""form-group"">
                            <label for=""city"">City</label>
                            <input type=""text"" class=""form-controls"" id=""city"" name=""city"">
                        </div>
                        <div class=""form-group"">
                            <label for=""zip"">Zip / Postcode</label>
                            <input type=""text"" class=""form-controls"" id=""zip"" name=""zip"">
  ");
                WriteLiteral(@"                      </div>
                        <div class=""form-group"">
                            <label for=""phone"">Mobile Phone</label>
                            <input type=""text"" class=""form-controls"" id=""phone"" name=""phone"">
                        </div>
                        <div class=""form-group"">
                            <label for=""newsletter"" class=""checkbox"" style=""width: 80%;"">
                                <input type=""checkbox"" name=""newsletter""
                                       id=""newsletter"">
                                <strong>
                                    Sign me up to the Astley
                                    Clarke newsletter to be the first to hear about new arrivals, seasonal sales, special offers and to
                                    receive exclusive birthday treats.
                                </strong>
                            </label>
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
                <div class=""right col-xs-6 col-md-6"">
                    <h2>DELIVERY ADDRESS</h2>
                    <div class=""form-group d-flex flex-column col-md-12 col-xs-12"">
                        <label for=""default"" class=""checkbox"">
                            <input type=""checkbox"" name=""default"" id=""default"">Default (same as
                            billing address)
                        </label>
                        <label for=""alternative"" class=""checkbox"">
                            <input type=""checkbox"" name=""alternative"" id=""alternative"">Add an
                            alternative delivery address
                        </label>
                    </div>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c54344fcf14806c11c2894cd73b9cb9618b65e415071", async() => {
                WriteLiteral(@"
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""firstName"">First Name</label>
                            <input type=""text"" class=""form-controls"" id=""firstName"" name=""firstName"">
                        </div>
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""lastName"">Last Name</label>
                            <input type=""text"" class=""form-controls"" id=""lastName"" name=""lastName"">
                        </div>
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""email"">Email</label>
                            <input type=""email"" class=""form-controls"" id=""email"" name=""email"">
                        </div>
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""country"">Country</label>
                            <select class=""form-controls"" id=""country"" name=""c");
                WriteLiteral("ountry\">\r\n                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c54344fcf14806c11c2894cd73b9cb9618b65e416476", async() => {
                    WriteLiteral("Vietnam");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""address1"">Address 1</label>
                            <input type=""text"" class=""form-controls"" id=""address1"" name=""address1"">
                        </div>
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""address2"">Address 2</label>
                            <input type=""text"" class=""form-controls"" id=""address2"" name=""address2"">
                        </div>
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""city"">City</label>
                            <input type=""text"" class=""form-controls"" id=""city"" name=""city"">
                        </div>
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""zip"">Zip / Postcode</label>
             ");
                WriteLiteral(@"               <input type=""text"" class=""form-controls"" id=""zip"" name=""zip"">
                        </div>
                        <div class=""form-group col-xs-12 col-md-12"">
                            <label for=""phone"">Mobile Phone</label>
                            <input type=""text"" class=""form-controls"" id=""phone"" name=""phone"">
                        </div>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </section>

            <section class=""order_fee col-xs-12 col-md-12"">
                <div class=""shipping col-xs-12 col-md-12"">
                    <h2>SHIPPING METHOD</h2>
                    <table class=""table table-sm text-center table-responsive"">
                        <thead>
                        <th>Method</th>
                        <th>Transportation</th>
                        <th>Transfer Days</th>
                        </thead>
                        <tbody>
                            <tr class=""table-light"">
                                <td class=""text-start ps-4"">
                                    <label for=""free"">
                                        <input type=""checkbox"" name=""free"" id=""free"">Free
                                    </label>
                                    <br>
                                    <small>Prepayment of duties and taxes supported</small>
                                </td>
   ");
            WriteLiteral(@"                             <td>EXPRESS COURIER (AIR)</td>
                                <td>Up to 4 business day(s)</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
                <div class=""taxes col-xs-12 col-md-12"">
                    <h2>DUTIES & TAXES</h2>
                    <ul>
                        <li>
                            <label for=""prepay"">
                                <input type=""checkbox"" name=""prepay"" id=""prepay"">Prepay ₫ 8984778 for duties, taxes and fees now to
                                guarantee no additional charges on delivery.
                            </label>
                        </li>
                        <li>
                            <label for=""pay-on-delivery"">
                                <input type=""checkbox"" name=""pay-on-delivery"" id=""pay-on-delivery"">I will pay all applicable duties, taxes
                                and fees on delivery.
  ");
            WriteLiteral(@"                          </label>
                        </li>
                    </ul>
                </div>
            </section>

            <section class=""order_payment col-xs-12 col-md-12"">
                <div class=""left col-xs-6 col-md-6"">
                    <h2>PAYMENT</h2>
                    <div class=""method col-xs-12 col-md-12"">
                        <img src=""https://www.astleyclarke.com/skin/frontend/default/astleyclarke/images/onestepcheckout_secure_cards_transparent.png"">
                    </div>
                    <div class=""form-group"">
                        <label for=""cardNumber"">Card Number</label>
                        <input type=""text"" class=""form-controls"" id=""cardNumber"" name=""cardNumber"">
                    </div>
                    <div class=""form-group"">
                        <label for=""expiry"">Expiry Date</label>
                        <input type=""date"" class=""form-controls"" id=""expiry"" name=""expiry"">
                    </div>
    ");
            WriteLiteral(@"                <div class=""form-group"">
                        <label for=""security"">Security Code</label>
                        <input type=""text"" class=""form-controls"" id=""security"" name=""security"">
                    </div>
                    <p>
                        By clicking Pay and Place Order, you agree to purchase your item(s) from Global-e as merchant of record for
                        this transaction, on Global-e’s Terms and Conditions and Privacy Policy. Global-e is an international
                        fulfilment service provider to Astley Clarke.
                    </p>
                    <div class=""form-group"">
                        <button type=""submit"" class=""btn checkout_button"" [routerLink]=""['/thank-you']"">
                            PLACE ORDER
                        </button>
                    </div>
                </div>
                <div class=""right col-xs-6 col-md-6"">
                    <h2>BILLING SUMMARY</h2>
                    <tabl");
            WriteLiteral(@"e class=""table-sm table-responsive col-xs-12 col-md-12"">
                        <tbody>
                            <tr>
                                <td class=""title"">ITEMS TOTAL</td>
                                <td class=""text-end"">₫ 23360421</td>
                            </tr>
                            <tr>
                                <td class=""title"">SHIPPING</td>
                                <td class=""text-end"">₫ 0</td>
                            </tr>
                            <tr>
                                <td class=""title"">DUTIES, TAXES & FEES</td>
                                <td class=""text-end"">₫ 8984778</td>
                            </tr>
                        </tbody>
                        <tfoot>
                            <tr>
                                <td class=""title"">TOTAL FOR YOUR ORDER</td>
                                <td class=""text-end"">₫ 32345199</td>
                            </tr>
                        </tfoot");
            WriteLiteral(">\r\n                    </table>\r\n                </div>\r\n            </section>\r\n\r\n        </div>\r\n    </div>\r\n</div>");
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
