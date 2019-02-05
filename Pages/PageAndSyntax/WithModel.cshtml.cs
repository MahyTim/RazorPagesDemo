using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages.PageAndSyntax
{
    public class WithModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        
        public void OnGet()
        {
            
        }
    }
}