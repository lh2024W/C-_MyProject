using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    [Serializable]
    public class OrderLeaf : OrderComponent, IComparable
    {
        public Car Car { get; set; }
        public DateTime DateTime { get; set; }

        public OrderLeaf() { }
        public OrderLeaf(string description, Car car) : base(description)
        {
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
            if (obj is OrderLeaf)
            {
                return DateTime.CompareTo((obj as OrderLeaf).DateTime);
            }
            throw new NotImplementedException();
        }
    }
}
