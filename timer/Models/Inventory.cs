using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace timer.Models
{
    [XmlRoot(ElementName = "inventory")]
    public class Inventory
    {
        public Inventory()
        {
            items = new List<item>();
        }

        [XmlElement(ElementName = "item")]
        public List<item> items { get; set; }

        public item this[string des]
        {
            get { return items.FirstOrDefault(s => string.Equals(s.Description, des, StringComparison.OrdinalIgnoreCase)); }
        }
    }

    public class item
    {
        [XmlElement("Description")]
        public string Description { get; set; }

        [XmlElement("Count")]
        public int Count { get; set; }
    }
}
