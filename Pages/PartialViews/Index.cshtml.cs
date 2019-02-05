using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesDemo.Pages.PartialViews
{
    public class Index : PageModel
    {
        public Person Person { get; set; }
        public void OnGet()
        {
            Person = new Person
            {
                LastName = "Maes",
                FirstName = "Partrick"
            };
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}