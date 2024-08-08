using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C__MyProject
{
    public class DataBaseOrders
    {
        string path = @"Orders.xml";

        public void SaveAllData(List<Order> orders)
        {
            var serializer = new XmlSerializer(typeof(List<Order>));
            var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, orders);
            sw.Close();
        }

        public void LoadAllData()
        {
            var serializer = new XmlSerializer(typeof(List<Order>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Order>)serializer.Deserialize(read);

            read.Close();

            foreach (var order in copy)
            {
                Console.WriteLine(order);
            }
        }

        public void FindOrderInFile(string licensePlate)
        {
            var serializer = new XmlSerializer(typeof(List<Order>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Order>)serializer.Deserialize(read);

            read.Close();

            foreach (var order in copy)
            {
                if (order.Description == licensePlate)
                {
                    Console.WriteLine(order);
                }
            }
        }

        public void SortOrders()
        {
            var serializer = new XmlSerializer(typeof(List<Order>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Order>)serializer.Deserialize(read);

            read.Close();

            copy.Sort();
            foreach (var order in copy)
            {
                Console.WriteLine(order);
            }
        }
    }
}
