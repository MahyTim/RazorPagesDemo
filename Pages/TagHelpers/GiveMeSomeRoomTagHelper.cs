using Microsoft.AspNetCore.Razor.TagHelpers;

namespace RazorPagesDemo.Pages.TagHelpers
{
    [HtmlTargetElement(Attributes = "givemesomeroom")]
    public class GiveMeSomeRoomTagHelper : TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.Attributes.RemoveAll("givemesomeroom");
            output.PreContent.SetHtmlContent("<div style=\"margin-top: 300px\">");
            output.PostContent.SetHtmlContent("</div>");
        }
    }
}