using System.Xml;

namespace Data
{
    public class Component
    {
        public string Name { get; set; }
        public Dictionary<string, int> Attributes { get; set; }
        public Component() 
        { 
            
        }
    }
}