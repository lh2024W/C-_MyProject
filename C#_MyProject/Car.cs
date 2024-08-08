using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    [Serializable]
    public class Car : Transport, IComparable
    {
        public Car() { }
        public Car(string brand, string model, int year, string licensePlate)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.LicensePlate = licensePlate;
        }

        public void PrintCar()
        {
            Console.WriteLine("Автомобиль: ");
            Console.WriteLine("Бренд: " + Brand);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Номерной знак: " + LicensePlate);
        }

        public int CompareTo(object obj)
        {
            if (obj is Car)
            {
                return Brand.CompareTo((obj as Car).Brand);
            }
            throw new NotImplementedException();
        }

        public object Clone()
        {
            Car temp = (Car)this.MemberwiseClone(); // поверхностная копия
            return temp;
        }

        
    }
}
