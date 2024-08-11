using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace C__MyProject
{
    public class DataBaseOrders
    {
        string path = @"Orders.xml";

        public void SaveAllData(List<OrderComponent> orders)
        {
            var serializer = new XmlSerializer(typeof(List<OrderComponent>));
            var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, orders);
            sw.Close();
        }
        
        public void LoadAllData()
        {
            /*using (var reader = XmlReader.Create(new StringReader(path), new XmlReaderSettings { ConformanceLevel = ConformanceLevel.Fragment }))
            {
               
            XmlSerializer formatter = new XmlSerializer(typeof(List<OrderComponent>));
            using (FileStream fs = new FileStream("orders.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, orders);
            }

            using (FileStream fs = new FileStream("orders.xml", FileMode.OpenOrCreate))
            {
                List<OrderComponent> orders1 = formatter.Deserialize(fs) as List<OrderComponent>;

                if (orders1 != null)
                {
                    foreach (var order in orders1)
                    {
                        Console.WriteLine(order);
                    }
                }
            }*/
            var serializer = new XmlSerializer(typeof(List<OrderComponent>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<OrderComponent>)serializer.Deserialize(read);

            read.Close();

            foreach (var order in copy)
            {
                Console.WriteLine(order);
            }
        }

    }
}
