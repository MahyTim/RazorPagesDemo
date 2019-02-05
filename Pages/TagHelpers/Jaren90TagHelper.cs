using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RazorPagesDemo.Pages.TagHelpers
{
    [HtmlTargetElement(Attributes = "jaren90")]
    public class Jaren90TagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("jaren90");
            output.PreContent.SetHtmlContent("<marquee>");
            output.PostContent.SetHtmlContent("</marquee>");
        }
    }
}