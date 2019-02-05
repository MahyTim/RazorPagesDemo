using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages.PageAndSyntax
{
    public class Routing : PageModel
    {
        [BindProperty(SupportsGet=true)]
        public int Id { get; set; }
        
        public void OnGet()
        {
            
        }
       
    }
}