using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class AirСonditioningСompressors : AirConditioningSystem //Компрессоры кондиционера
    {
        public string Name { get; set; } // Наименование
        public string CountryManufacturer { get; set; } // Страна производитель
        public string ManufacturerName { get; set; } // Производитель
        public string Length { get; set; } // Длина мм
        public string Height { get; set; } // Высота мм
        public int NumberOfRibs { get; set; } // Количество ребер
        public string Pulley { get; set; } // Шкива мм
        public string Weight { get; set; } // Вес г
        public string AmountOfOil { get; set; } // Количество масла мл
        public string Coolant { get; set; } // Хладагент
        public string Inlet { get; set; } // Впускной мм
        public string Outlet { get; set; } // Выпускной мм
        public string CompressorOil { get; set; } // Компресорное масло

        public void PrintAirСonditioningСompressors()
        {
            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Страна производитель: " + CountryManufacturer);
            Console.WriteLine("Производитель: " + ManufacturerName);
            Console.WriteLine("Длина (мм): " + Length);
            Console.WriteLine("Высота (мм): " + Height);
            Console.WriteLine("Количество ребер: " + NumberOfRibs);
            Console.WriteLine("Шкива (мм): " + Pulley);
            Console.WriteLine("Вес (г): " + Weight);
            Console.WriteLine("Количество масла (мл): " + AmountOfOil);
            Console.WriteLine("Хладагент: " + Coolant);
            Console.WriteLine("Впускной (мм): " + Inlet);
            Console.WriteLine("Выпускной (мм): " + Outlet);
            Console.WriteLine("Компресорное масло: " + CompressorOil);
        }
    }
}
