using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C__MyProject
{
    [XmlInclude(typeof(OrderComposite))]
    [XmlInclude(typeof(OrderLeaf))]
    public abstract class OrderComponent 
    {
        public string Description { get; set; }

        public OrderComponent() : this ("Не задано")  { }
        public OrderComponent(string description)
        {           
            this.Description = description;
        }

        public object Clone() // глубокое копирование
        {
            OrderComponent temp = (OrderComponent)this.MemberwiseClone(); // поверхностная копия

            return temp;
        }
    }
}
