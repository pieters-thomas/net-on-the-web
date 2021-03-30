namespace net_on_the_web.Models
{
    public class Class
    {
        public uint Id;
        public string Name { get;}
        public uint TeacherId;
        
        
        public Class( uint anId, string aName, uint aClassId)
        {
            Id = anId;
            Name = aName;
            TeacherId = aClassId;
            
        }
    }
}