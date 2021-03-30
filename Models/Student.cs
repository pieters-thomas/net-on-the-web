using System.Diagnostics;
using System.Reflection;

namespace net_on_the_web.Models
{
    public class Student
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public Class Class { get; set; }

        public Student( uint anId, string aName, Class aClass)
        {
            Id = anId;
            Name = aName;
            Class = aClass;
        }
    }
}