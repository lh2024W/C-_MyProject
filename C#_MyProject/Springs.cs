using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public abstract class Springs : ChassisParts //Рессоры
    {
        public string Name { get; set; } // Наименование
        public string CountryManufacturer { get; set; } // Страна производитель
        public string ManufacturerName { get; set; } // Производитель
        public string Accommodation { get; set; } // Размещение
        public string CarBrand { get; set; } // Марка автомобиля
        public string CarModel { get; set; } // Модель автомобиля
        public string Length { get; set; } // Длина мм
        public string Width { get; set; } // Ширина мм
        public string ThicknessInTheCenter { get; set; } // Толщина по центру мм
        
        public void PrintBearings()
        {
            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Страна производитель: " + CountryManufacturer);
            Console.WriteLine("Производитель: " + ManufacturerName);
            Console.WriteLine("Размещение: " + Accommodation);
            Console.WriteLine("Марка автомобиля: " + CarBrand);
            Console.WriteLine("Модель автомобиля: " + CarModel);
            Console.WriteLine("Длина (мм): " + Length);
            Console.WriteLine("Ширина (мм): " + Width);
            Console.WriteLine("Толщина по центру (мм): " + ThicknessInTheCenter);
        }
    }
}
