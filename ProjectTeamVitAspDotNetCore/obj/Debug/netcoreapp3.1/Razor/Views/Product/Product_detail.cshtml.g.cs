#pragma checksum "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\Product\Product_detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57d9bd0bf5d17e8063b88dfff78cc2dc6431bd52"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Product_detail), @"mvc.1.0.view", @"/Views/Product/Product_detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57d9bd0bf5d17e8063b88dfff78cc2dc6431bd52", @"/Views/Product/Product_detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e248320fd3eae94d921c736a1001947d916d09fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Product_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/product-detail.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57d9bd0bf5d17e8063b88dfff78cc2dc6431bd524858", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "57d9bd0bf5d17e8063b88dfff78cc2dc6431bd525125", async() => {
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
<div class=""product_detail container"">
    <div class=""row"">
        <!-- !TODO: breadcrumb -->
        <section class=""product_detail-breadcrumb col-xs-12 col-md-12"">
            Home > Jewellery > Bracelets > <strong>Interstellar Diamond Bangle</strong>
        </section>

        <section class=""product_detail-info col-xs-12 col-md-12"">
            <div class=""left col-xs-6 col-md-6"">
                <div class=""list_img col-xs-4 col-md-4"">
                    <ul>
                        <li>
                            <img src=""https://www.astleyclarke.com/media/catalog/product/cache/1/thumbnail/200x200/9df78eab33525d08d6e5fb8d27136e95/4/5/45044ynob_a/Astley-Clarke-Interstellar-Diamond-Bangle-Yellow-Gold-(Solid,-100-Recycled)-45044YNOB.jpg"">
                        </li>
                        <li>
                            <img src=""https://www.astleyclarke.com/media/catalog/product/cache/1/thumbnail/200x200/9df78eab33525d08d6e5fb8d27136e95/4/5/45044ynob_ugc_99-2655/Astley-Clarke-Interstellar-Diamo");
            WriteLiteral(@"nd-Bangle-Yellow-Gold-(Solid,-100-Recycled)-45044YNOB.jpg"">
                        </li>
                        <li>
                            <img src=""https://www.astleyclarke.com/media/catalog/product/cache/1/thumbnail/200x200/9df78eab33525d08d6e5fb8d27136e95/a/c/ac_stellar_1820a_1_11/Astley-Clarke-Interstellar-Diamond-Bangle-Yellow-Gold-(Solid,-100-Recycled)-45044YNOB.jpg"">
                        </li>
                        <li>
                            <img src=""https://www.astleyclarke.com/media/catalog/product/cache/1/thumbnail/200x200/9df78eab33525d08d6e5fb8d27136e95/a/c/ac-interstellar-still1765/Astley-Clarke-Interstellar-Diamond-Bangle-Yellow-Gold-(Solid,-100-Recycled)-45044YNOB.jpg"">
                        </li>
                    </ul>
                </div>
                <div class=""detail_img col-xs-8 col-md-8"">
                    <img src=""https://www.astleyclarke.com/media/catalog/product/cache/1/image/420x420/9df78eab33525d08d6e5fb8d27136e95/4/5/45044ynob_a/Astley-Clarke-Inters");
            WriteLiteral(@"tellar-Diamond-Bangle-Yellow-Gold-(Solid,-100-Recycled)-45044YNOB.jpg"">
                </div>
            </div>
            <div class=""right col-xs-6 col-md-6"">
                <div class=""name col-xs-12 col-md-12"">
                    <h3>
                        Name: Interstellar Diamond Bangle
                    </h3>
                    <h4>
                        Price: ₫63,743,102
                    </h4>
                    <h5>
                        Code: 45044YNOB
                    </h5>

                </div>
                <div class=""description col-xs-12 col-md-12"">
                    <p>
                        The first diamond bangle to be featured in a fine collection, this Interstellar bangle features an impactful
                        surface made up of clusters of brilliant cut diamonds, set into an elegant line of solid 14ct gold. Designed
                        to sit comfortably on the wrist, the bangle features a double security clasp. This luxurious bracelet is
      ");
            WriteLiteral(@"                  made for stacking in with different designs for a unique statement, or can be worn alone for relaxed
                        opulence.
                    </p>
                    <ul>
                        <li>First of its kind diamond bangle</li>
                        <li>Features a surface made of clusters of brilliant cut diamonds</li>
                        <li>Set in solid 14 carat gold</li>
                        <li>Double security clasp for optimum safety</li>
                        <li>Produced using 100% recycled gold</li>
                        <li>All of our diamonds are natural and ethically sourced</li>
                    </ul>
                </div>
                <div class=""colors col-xs-12 col-md-12"">
                    <ul>
                        <li><img src=""https://www.astleyclarke.com/uk/jewellery/bracelets/interstellar-diamond-bangle""></li>
                    </ul>
                </div>
                
                <div class=""action d-flex flex-col");
            WriteLiteral("umn justify-content-center align-items-center col-xs-12 col-md-12\">\n                    <button class=\"btn add_button col-xs-12 col-md-12\" type=\"button\">\n\n                        <td>\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57d9bd0bf5d17e8063b88dfff78cc2dc6431bd5211484", async() => {
                WriteLiteral("Buy Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\son10\OneDrive\Tài liệu\GitHub\TeamVit\Project_Duck_Team\ProjectTeamVitAspDotNetCore\Views\Product\Product_detail.cshtml"
                                                                        WriteLiteral(ViewBag.product.PdId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </td>
                    </button>
                    <button class=""btn hint_button col-xs-12 col-md-12"" type=""button"">
                        DROP A HINT
                    </button>
                </div>
            </div>
        </section>

        <section class=""product_detail-addon col-xs-12 col-md-12"">
            <div class=""left col-xs-6 col-md-6"">
                <div class=""mini col-xs-12 col-md-12"">
                    <nav id=""myTab"" role=""tablist"" class=""col-xs-12 col-md-12"">
                        <div class=""col-xs-12 col-md-12"">
                            <ul class=""nav nav-tabs"">
                                <li class=""nav-item col-xs-4 col-md-4"">
                                    <a class=""nav-link active"" id=""tab1"" data-toggle=""tab"" href=""#tab1"" role=""tab"" aria-controls=""tab1""
                                       aria-selected=""true"">Home</a>
                                </li>
                                <li class=""nav-item col-xs-4 col-md-4""");
            WriteLiteral(@">
                                    <a class=""nav-link"" id=""tab2"" data-toggle=""tab"" href=""#tab2"" role=""tab"" aria-controls=""tab2""
                                       aria-selected=""false"">Profile</a>
                                </li>
                                <li class=""nav-item col-xs-4 col-md-4"">
                                    <a class=""nav-link"" id=""tab3"" data-toggle=""tab"" href=""#tab3"" role=""tab"" aria-controls=""tab3""
                                       aria-selected=""false"">Contact</a>
                                </li>
                            </ul>
                        </div>
                    </nav>
                    <div class=""tab-content col-xs-12 col-md-12"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""tab1"" role=""tabpanel"" aria-labelledby=""tab1-tab"">
                            <table class=""text-center col-xs-12 col-md-12"">
                                <tr>
                                    <td>Collection</td>
        ");
            WriteLiteral(@"                            <td>Interstellar</td>
                                </tr>
                                <tr>
                                    <td>Gemstone</td>
                                    <td>Diamond</td>
                                </tr>
                                <tr>
                                    <td>Diamond Specification</td>
                                    <td>0.13ct White</td>
                                </tr>
                                <tr>
                                    <td>Metal</td>
                                    <td>Yellow Gold (Solid, 100% Recycled)</td>
                                </tr>
                                <tr>
                                    <td>Metal Type</td>
                                    <td>14 Carat Gold</td>
                                </tr>
                            </table>
                        </div>
                        <div class=""tab-pane fade"" id=""tab2"" role=""tabpanel"" aria-labelled");
            WriteLiteral(@"by=""tab2-tab"">tab2</div>
                        <div class=""tab-pane fade"" id=""tab3"" role=""tabpanel"" aria-labelledby=""tab3-tab"">tab3</div>
                    </div>
                </div>
                <div class=""delivery col-xs-12 col-md-12"">

                    <h3 class=""bg-dark text-center col-xs-12 col-md-12"">DELIVERY & RETURNS</h3>
                    <div class=""delivery_info"">
                        <h4><i class=""fas fa-truck""></i> <strong>FREE SHIPPING</strong> on all (Country) orders.</h4>
                        <ul>
                            <li>Sent by Express Courier (Air)</li>
                            <li>Up to 4 working days delivery time</li>
                        </ul>


                        <h4><i class=""fas fa-exchange-alt""></i> <strong>FREE RETURNS*</strong></h4>
                        <ul>
                            <li>All items, including earrings, are returnable within 14 days of receipt.</li>
                            <li style=""list-style: none; font-style: ital");
            WriteLiteral(@"ic;"">*Up to 4 working days delivery time</li>
                        </ul>
                    </div>
                </div>
            </div>

            <div class=""right col-xs-6 col-md-6"">
                <div class=""options col-xs-12 col-md-12"">
                    <h3 class=""title text-center"">
                        YOU MAY ALSO LIKE
                    </h3>

                    <div class=""d-flex align-items-center justify-content-center"">
                        <a [routerLink]=""['/accessories/bracelet']"" class=""col-xs-4 col-md-4"">
                            <div class=""text-center"">
                                <img src=""https://www.astleyclarke.com/media/catalog/product/4/1/41006ywtb-a.jpg""
                                     class=""one-edge-shadow"">
                                <h3 class=""text-center"">
                                    Mother of Pearl Floris Kula Bracelet
                                </h3>
                            </div>
                        </a>
          ");
            WriteLiteral(@"              <a [routerLink]=""['/accessories/rings']"" class=""col-xs-4 col-md-4"">
                            <div class=""text-center"">
                                <img src=""https://www.astleyclarke.com/media/catalog/product/4/4/44036snon-a.jpg""
                                     class=""one-edge-shadow"">
                                <h3 class=""text-center"">
                                    Biography Cosmos Locket Necklace
                                </h3>
                            </div>
                        </a>
                        <a [routerLink]=""['/accessories/earrings']"" class=""col-xs-4 col-md-4"">
                            <div class=""text-center"">
                                <img src=""https://www.astleyclarke.com/media/catalog/product/3/9/39078snob_a_spiga.jpg""
                                     class=""one-edge-shadow"">
                                <h3>
                                    Cylinder Kula Biography Bracelet
                                </h3>
         ");
            WriteLiteral(@"                   </div>
                        </a>
                    </div>
                </div>

                <div class=""public col-xs-12 col-md-12"">
                    <h3 class=""title text-center"">
                        #AstleyClarke
                    </h3>

                    <h2 class=""text-center"">
                        BE THE INSPIRATION – SHOW US HOW YOU WEAR YOURS
                    </h2>

                    <div class=""d-flex align-items-center justify-content-center"">
                        <a [routerLink]=""['/accessories/bracelet']"" class=""col-xs-4 col-md-4"">
                            <div class=""text-center"">
                                <img src=""https://www.astleyclarke.com/media/cms/home/2021-01-08/top-promo-bracelets-d.jpg""
                                     class=""one-edge-shadow"">
                                <h3 class=""text-center"">
                                    Mother of Pearl Floris Kula Bracelet
                                </h3>
               ");
            WriteLiteral(@"             </div>
                        </a>
                        <a [routerLink]=""['/accessories/rings']"" class=""col-xs-4 col-md-4"">
                            <div class=""text-center"">
                                <img src=""https://www.astleyclarke.com/media/cms/home/2021-01-08/top-promo-rings-d.jpg""
                                     class=""one-edge-shadow"">
                                <h3 class=""text-center"">
                                    Biography Cosmos Locket Necklace
                                </h3>
                            </div>
                        </a>
                        <a [routerLink]=""['/accessories/earrings']"" class=""col-xs-4 col-md-4"">
                            <div class=""text-center"">
                                <img src=""https://www.astleyclarke.com/media/cms/home/2021-01-08/top-promo-earrings-d.jpg""
                                     class=""one-edge-shadow"">
                                <h3>
                                    Cylinder Kul");
            WriteLiteral(@"a Biography Bracelet
                                </h3>
                            </div>
                        </a>
                    </div>
                </div>
            </div>
        </section>

        <section class=""product_detail-review col-xs-12 col-md-12"">
            <h3 class=""review-title col-xs-12 col-md-12 text-center"">REVIEWS</h3>
            <div class=""customer col-xs-12 col-md-12"">
                <div class=""info col-xs-12 col-md-12"">
                    <div class=""left col-xs-6 col-md-6"">
                        <h3>Emma Y.</h3>
                        <h4>(United Kingdom - 03/01/2021)</h4>
                        <span>
                            <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i>
                        </span>
                    </div>
                    <div class=""right col-xs-6 col-md-6"">
                        <ul>
                            <li>Metal: product's m");
            WriteLiteral(@"etal |</li>
                            <li>Gemstone: product's gemstone |</li>
                            <li style=""color: green; font-weight: bold;"">Verified purchase</li>
                        </ul>
                    </div>
                </div>
                <div class=""comment col-xs-12 col-md-12"">
                    <p>
                        Gorgeous bracelet. I bought this as the opal version had been on my wish list for a while, but sold out.
                        The bracelet is dainty, very beautiful and extremely good quality.
                    </p>
                </div>
            </div>
            <div class=""customer col-xs-12 col-md-12"">
                <div class=""info col-xs-12 col-md-12"">
                    <div class=""left col-xs-6 col-md-6"">
                        <h3>Emma Y.</h3>
                        <h4>(United Kingdom - 03/01/2021)</h4>
                        <span>
                            <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas f");
            WriteLiteral(@"a-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i>
                        </span>
                    </div>
                    <div class=""right col-xs-6 col-md-6"">
                        <ul>
                            <li>Metal: product's metal |</li>
                            <li>Gemstone: product's gemstone |</li>
                            <li style=""color: green; font-weight: bold;"">Verified purchase</li>
                        </ul>
                    </div>
                </div>
                <div class=""comment col-xs-12 col-md-12"">
                    <p>
                        Gorgeous bracelet. I bought this as the opal version had been on my wish list for a while, but sold out.
                        The bracelet is dainty, very beautiful and extremely good quality.
                    </p>
                </div>
            </div>
            <div class=""customer col-xs-12 col-md-12"">
                <div class=""info col-xs-12 col-md-12"">
                    <div c");
            WriteLiteral(@"lass=""left col-xs-6 col-md-6"">
                        <h3>Emma Y.</h3>
                        <h4>(United Kingdom - 03/01/2021)</h4>
                        <span>
                            <i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i><i class=""fas fa-star""></i>
                        </span>
                    </div>
                    <div class=""right col-xs-6 col-md-6"">
                        <ul>
                            <li>Metal: product's metal |</li>
                            <li>Gemstone: product's gemstone |</li>
                            <li style=""color: green; font-weight: bold;"">Verified purchase</li>
                        </ul>
                    </div>
                </div>
                <div class=""comment col-xs-12 col-md-12"">
                    <p>
                        Gorgeous bracelet. I bought this as the opal version had been on my wish list for a while, but sold out.
                        The bra");
            WriteLiteral("celet is dainty, very beautiful and extremely good quality.\n                    </p>\n                </div>\n            </div>\n        </section>\n    </div>\n</div>");
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