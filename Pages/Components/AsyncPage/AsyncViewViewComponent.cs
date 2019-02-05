using Microsoft.AspNetCore.Mvc;

namespace RazorPagesDemo.Pages.Components.AsyncPage
{
    public class AsyncPageViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string url)
        {
            return View("Default", url);
        }
    }
}