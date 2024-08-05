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
        string path = @"C:\Users\user\Desktop\Stock.xml";

        public void SaveAllData(SortedDictionary<int, Good> goods)
        {
            var serializer = new XmlSerializer(typeof(SortedDictionary<int, Good>));
            var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, goods);
            sw.Close();
        }

        public void LoadAllData()
        {
            var serializer = new XmlSerializer(typeof(SortedDictionary<int, Good>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (SortedDictionary<int, Good>)serializer.Deserialize(read);

            read.Close();

            foreach (var good in copy)
            {
                Console.WriteLine(good);
            }
        }

    }
}
