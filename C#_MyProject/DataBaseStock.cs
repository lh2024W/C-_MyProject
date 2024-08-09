using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C__MyProject
{
    public class DataBaseStock
    {
        string path = @"Stock.xml";

        public void SaveAllData(SortedDictionary<int, Details> goods)
        {
            var serializer = new XmlSerializer(typeof(SortedDictionary<int, Details>));
            var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, goods);
            sw.Close();
        }

        public void LoadAllData()
        {
            var serializer = new XmlSerializer(typeof(SortedDictionary<int, Details>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (SortedDictionary<int, Details>)serializer.Deserialize(read);

            read.Close();

            foreach (var good in copy)
            {
                Console.WriteLine(good);
            }
        }

    }
}
