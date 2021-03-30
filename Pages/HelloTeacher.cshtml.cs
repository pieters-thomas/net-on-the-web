using Microsoft.AspNetCore.Mvc.RazorPages;
using net_on_the_web.Models;

namespace net_on_the_web.Pages
{
    public class HelloTeacher : PageModel
    {

        public Teacher Becode;
        
        public void OnGet()
        {
            Becode = new Teacher(1, "Becode");
        }
    }
}