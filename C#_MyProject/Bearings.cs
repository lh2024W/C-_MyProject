using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public abstract class Bearings : ChassisParts // подшипники
    {
        public string Name { get; set; } // Наименование
        public string CountryManufacturer { get; set; } // Страна производитель
        public string ManufacturerName { get; set; } // Производитель
        public string Accommodation { get; set; } // Размещение
        public string Width1 { get; set; } // Ширина1 мм
        public string Width2 { get; set; } // Ширина2 мм
        public string OutsideDiameter1 { get; set; } // Наружный диаметр1 мм
        public string OutsideDiameter2 { get; set; } // Наружный диаметр2 мм
        public string InnerDiameter1 { get; set; } // Внутрений диаметр1 мм
        public string InnerDiameter2 { get; set; } // Внутрений диаметр2 мм

        public void PrintBearings()
        {
            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Страна производитель: " + CountryManufacturer);
            Console.WriteLine("Производитель: " + ManufacturerName);
            Console.WriteLine("Размещение: " + Accommodation);
            Console.WriteLine("Ширина1 (мм): " + Width1);
            Console.WriteLine("Ширина2 (мм): " + Width2);
            Console.WriteLine("Наружный диаметр1 (мм): " + OutsideDiameter1);
            Console.WriteLine("Наружный диаметр2 (мм): " + OutsideDiameter2);
            Console.WriteLine("Внутрений диаметр1 (мм): " + InnerDiameter1);
            Console.WriteLine("Внутрений диаметр2 (мм): " + InnerDiameter2);
        }
    }
}
