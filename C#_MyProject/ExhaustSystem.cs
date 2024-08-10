using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class ExhaustSystem : ExhaustSystemParts //Выхлопная система
    {
        public string Name { get; set; } // Наименование
        public string CountryManufacturer { get; set; } // Страна производитель
        public string ManufacturerName { get; set; } // Производитель
        public string Material { get; set; } // Материал
        public string MetalThickness { get; set; } // Толщина метала мм

        public void PrintExhaustSystem()
            {
                Console.WriteLine("Наименование: " + Name);
                Console.WriteLine("Страна производитель: " + CountryManufacturer);
                Console.WriteLine("Производитель: " + ManufacturerName);
                Console.WriteLine("Материал: " + Material);
                Console.WriteLine("Толщина метала (мм): " + MetalThickness);
            }
        }
}
