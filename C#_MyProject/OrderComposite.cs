using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class OrderComposite : OrderComponent, IComparable
    {
        Car car;
        public DateTime DateTime { get; set; }

        public OrderComposite() : this ("Не задано", "Не задано", "Не задано", 2000, "Не задано") { }
        public OrderComposite (string description, string brand, string model, int year, string licensePlate) 
            : base (description)
        {
            Car car = new Car (brand, model, year, licensePlate);
            this.car = car;
            this.DateTime = DateTime.Now;
            this.Description = description;
        }

        public override string ToString()
        {
            return "Марка: " + car.Brand + ' ' + "Модель: " + car.Model + ' ' + "Год выпуска: " + car.Year + ' '
                + "Номерной знак: " + car.LicensePlate + ' ' + "Описание работ: " + Description + ' ' +
                "Дата оформления заказа: " + DateTime;
        }

        public void PrintOrder()
        {
            Console.WriteLine("Автомобиль: ");
            Console.WriteLine("Марка: " + car.Brand);
            Console.WriteLine("Модель: " + car.Model);
            Console.WriteLine("Номерной знак: " + car.LicensePlate);
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
