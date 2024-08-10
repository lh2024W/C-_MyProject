using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class Starters : ElectricalDetails //Стартеры
    {
        public string Name { get; set; } // Наименование
        public string CountryManufacturer { get; set; } // Страна производитель
        public string ManufacturerName { get; set; } // Производитель
        public string CarBrand { get; set; } // Марка автомобиля
        public string CarModel { get; set; } // Модель автомобиля
        public string YearCar { get; set; } // Год выпуска автомобиля
        public int NumberOfTeeth { get; set; } // Количество зубцов
        public string Voltage { get; set; } // Напряжение В
        public string Dimensions { get; set; } // Габариты мм
        
        public void PrintStarters()
        {
            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Страна производитель: " + CountryManufacturer);
            Console.WriteLine("Производитель: " + ManufacturerName);
            Console.WriteLine("Марка автомобиля: " + CarBrand);
            Console.WriteLine("Модель автомобиля: " + CarModel);
            Console.WriteLine("Год выпуска автомобиля: " + YearCar);
            Console.WriteLine("Количество зубцов: " + NumberOfTeeth);
            Console.WriteLine("Напряжение (В): " + Voltage);
            Console.WriteLine("Габариты (мм): " + Dimensions);
        }
    }
}
