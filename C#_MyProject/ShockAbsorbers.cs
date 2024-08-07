using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public abstract class ShockAbsorbers : ChassisParts // амортизаторы
    {
        public string Name { get; set; } // Наименование
        public string CountryManufacturer { get; set; } // Страна производитель
        public string ManufacturerName { get; set; } // Производитель
        public string Accommodation { get; set; } // Размещение
        public string Side { get; set; } // Сторона
        public string TypeOfFiller { get; set; } // Вид наполнителя 
        public int QuantityPerAxle { get; set; } // Количество на ось
        public string Guarantee { get; set; } // Гарантия
        public string WarrantyIncluded { get; set; } // Гарантия в комплекте
        
        public void PrintShockAbsorbers()
        {
            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Страна производитель: " + CountryManufacturer);
            Console.WriteLine("Производитель: " + ManufacturerName);
            Console.WriteLine("Размещение: " + Accommodation);
            Console.WriteLine("Сторона: " + Side);
            Console.WriteLine("Вид наполнителя: " + TypeOfFiller);
            Console.WriteLine("Количество на ось: " + QuantityPerAxle);
            Console.WriteLine("Гарантия: " + Guarantee);
            Console.WriteLine("Гарантия в комплекте: " + WarrantyIncluded);
        }
    }
}
