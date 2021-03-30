using Microsoft.AspNetCore.Mvc.RazorPages;
using net_on_the_web.Models;

namespace net_on_the_web.Pages
{
    public class HelloClass : PageModel
    {
        public Class Isengard { get; } = new Class(1, "Isengard", 1);
        public Class ErrorRoom = new Class(1, "Error-Room", 2);
        public Class Rtfm = new Class(1, "RTFM", 3);
        public Class PirateBay = new Class(1, "Pirate-Bay", 4);
        public Class SoundOfCoding = new Class(1, "The Sound of Coding", 5);
        
        public void OnGet()
        {
        }
    }
}