using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class Order : IComparable
    {
        //DataBaseCars cars;
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string LicensePlate { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }

        public Order(string description, Car car)
        {           
            this.Brand = car.Brand;
            this.Model = car.Model;
            this.Year = car.Year;
            this.LicensePlate = car.LicensePlate;
            this.DateTime = DateTime.Now;
            this.Description = description;
        }

        public void PrintOrder()
        {
            Console.WriteLine("Автомобиль: ");
            Console.WriteLine("Бренд: " + Brand);
            Console.WriteLine("Модель: " + Model);
            Console.WriteLine("Год выпуска: " + Year);
            Console.WriteLine("Номерной знак: " + LicensePlate);
            Console.WriteLine("Описание работ: " + Description);
            Console.WriteLine("Дата оформления заказа: " + DateTime);
        }

        public int CompareTo(object obj)
        {
            if (obj is Order)
            {
                return DateTime.CompareTo((obj as Order).DateTime);
            }
            throw new NotImplementedException();
        }

        public object Clone() // глубокое копирование
        {
            Order temp = (Order)this.MemberwiseClone(); // поверхностная копия

            return temp;
        }
    }
}
