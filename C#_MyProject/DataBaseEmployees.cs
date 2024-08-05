using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C__MyProject
{
    public class DataBaseEmployees
    {
        string path = @"C:\Users\user\Desktop\Employees.xml";

        public void SaveAllData(List<Worker> employees)
        {
            var serializer = new XmlSerializer(typeof(List<Worker>));
            var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, employees);
            sw.Close();
        }

        public void LoadAllData()
        {
            var serializer = new XmlSerializer(typeof(List<Worker>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Worker>)serializer.Deserialize(read);

            read.Close();

            foreach (var worker in copy)
            {
                Console.WriteLine(worker);
            }
        }

        public void FindWorkerInFile(string lastName)
        {
            var serializer = new XmlSerializer(typeof(List<Worker>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Worker>)serializer.Deserialize(read);

            read.Close();

            foreach (var worker in copy)
            {
                if (worker.LastName == lastName)
                {
                    Console.WriteLine(worker);
                }
            }
        }

        public void SortEmployees()
        {
            var serializer = new XmlSerializer(typeof(List<Worker>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Worker>)serializer.Deserialize(read);

            read.Close();

            copy.Sort();
            foreach (var worker in copy)
            {
                Console.WriteLine(worker);
            }
        }
    }
}
