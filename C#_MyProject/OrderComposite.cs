using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    [Serializable]
    public class OrderComposite : OrderComponent, IComparable
    {
        public Car Car { get; set; }
        public DateTime DateTime { get; set; }

        public OrderComposite() : this ("Не задано", "Не задано", "Не задано", 2000, "Не задано") { }
        public OrderComposite (string description, string brand, string model, int year, string licensePlate) 
            : base (description)
        {
            Car car = new Car (brand, model, year, licensePlate);
            this.Car = car;
            this.DateTime = DateTime.Now;
            this.Description = description;
        }

        public override string ToString()
        {
            return "Марка: " + Car.Brand + ' ' + "Модель: " + Car.Model + ' ' + "Год выпуска: " + Car.Year + ' '
                + "Номерной знак: " + Car.LicensePlate + ' ' + "Описание работ: " + Description + ' ' +
                "Дата оформления заказа: " + DateTime;
        }

        public void PrintOrder()
        {
            Console.WriteLine("Автомобиль: ");
            Console.WriteLine("Марка: " + Car.Brand);
            Console.WriteLine("Модель: " + Car.Model);
            Console.WriteLine("Номерной знак: " + Car.LicensePlate);
            Console.WriteLine("Описание работ: " + Description);
            Console.WriteLine("Дата оформления заказа: " + DateTime);
        }

        public int CompareTo(object obj)
        {
            if (obj is OrderComposite)
            {
                return DateTime.CompareTo((obj as OrderComposite).DateTime);
            }
            throw new NotImplementedException();
        }
    }
}
