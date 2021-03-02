using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using DrinkStores.Models.ViewModels;
using System.Collections.Generic;

namespace DrinkStores.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")] // create link taghelper
    public class PageLinkTagHelper : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public PagingInfo PageModel { get; set; }
        public string PageAction { get; set; } 


        [HtmlAttributeName(DictionaryAttributePrefix = "page-url-")] // điều hướng bằng url
        public Dictionary<string, object> PageUrlValues { get; set; }
        = new Dictionary<string, object>();


        public bool PageClassesEnabled { get; set; } = false;
        public string PageClass { get; set; }
        public string PageClassNormal { get; set; } //những thuộc tính sẽ hiển thị chỗ phân trang có ở cuối file index
        public string PageClassSelected { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div"); // build thẻ div ra màn hình
            for (int i = 1; i <= PageModel.TotalPages; i++)//; có bao nhiêu i thì có bấy nhiêu page
            {
                TagBuilder tag = new TagBuilder("a"); // build thẻ a và có thuộc tính href là Action
                PageUrlValues["productPage"] = i;
                tag.Attributes["href"] = urlHelper.Action(PageAction, PageUrlValues);

                //tag.Attributes["href"] = urlHelper.Action(PageAction, new
                //{
                //    productPage = i
                //});
                if (PageClassesEnabled)
                {
                    tag.AddCssClass(PageClass);
                    tag.AddCssClass(i == PageModel.CurrentPage ? PageClassSelected : PageClassNormal); // nếu page hiện tại thì chọn màu là class Normal
                }
                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);

            }
            output.Content.AppendHtml(result.InnerHtml);

        }


    }
}
