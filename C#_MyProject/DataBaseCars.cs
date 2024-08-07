using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace C__MyProject
{
    public class DataBaseCars
    {

        string path = @"Cars.xml";

        public void SaveAllData(List<Car> cars)
        {
            var serializer = new XmlSerializer(typeof(List<Car>));
            var fs = new FileStream(path, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            serializer.Serialize(sw, cars);
            sw.Close();
        }

        public void LoadAllData()
        {
            var serializer = new XmlSerializer(typeof(List<Car>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Car>)serializer.Deserialize(read);

            read.Close();

            foreach (var car in copy)
            {
                Console.WriteLine(car);
            }
        }

        public Car FindCarInFile(string licensePlate)
        {
            var serializer = new XmlSerializer(typeof(List<Car>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Car>)serializer.Deserialize(read);

            read.Close();

            foreach (var car in copy)
            {
                if (car.LicensePlate == licensePlate)
                {
                    return car;
                }
            }
            return null;
        }

        public void SortCars()
        {
            var serializer = new XmlSerializer(typeof(List<Car>));
            var read = new FileStream(path, FileMode.Open, FileAccess.Read);
            var copy = (List<Car>)serializer.Deserialize(read);

            read.Close();

            copy.Sort();
            foreach (var car in copy)
            {
                Console.WriteLine(car);
            }
        }

    }
}
