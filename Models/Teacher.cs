namespace net_on_the_web.Models
{
    public class Teacher
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        

        public Teacher( uint anId, string aName)
        {
            Id = anId;
            Name = aName;
        }
    }
}