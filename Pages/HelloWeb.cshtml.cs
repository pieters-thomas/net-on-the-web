using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.RazorPages;
using net_on_the_web.Models;

namespace net_on_the_web.Pages
{
    public class HelloWebModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";
        public List<Student> Students;
        

        public void OnGet()
        {
            HelloClass inClass = new HelloClass();
            
            Students = new List<Student>();
            Students.Add(new Student(1, "Sicco", inClass.Isengard));
            Students.Add(new Student(1, "Koen", inClass.Isengard));
            Students.Add(new Student(1, "Tam", inClass.ErrorRoom));
            Students.Add(new Student(1, "Tem", inClass.Rtfm));
            Students.Add(new Student(1, "Tim", inClass.PirateBay));
            Students.Add(new Student(1, "Tom", inClass.PirateBay));
            Students.Add(new Student(1, "Tum", inClass.PirateBay));
            Students.Add(new Student(1, "Tym", inClass.SoundOfCoding));
        }
    }
}