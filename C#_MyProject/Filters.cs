using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public abstract class Filters : EngineParts //Фильтры
    {
        public string Name { get; set; } // Наименование
        public string CountryManufacturer { get; set; } // Страна производитель
        public string ManufacturerName { get; set; } // Производитель
        public string FilterType { get; set; } // Тип фильтра
        public string ExecutingFilter { get; set; } // Выполнение фильтра
        public string Height { get; set; } // Высота мм
        public string OutsideDiameter1 { get; set; } // Наружный диаметр1 мм
        public string OutsideDiameter2 { get; set; } // Наружный диаметр2 мм
        public string SealedGasketDiameter { get; set; } // Диаметр уплотненной прокладки мм
        public string InternalThread { get; set; } // Внутреняя резьба мм
        public string Guarantee { get; set; } // Гарантия

        public void PrintFilters()
        {
            Console.WriteLine("Наименование: " + Name);
            Console.WriteLine("Страна производитель: " + CountryManufacturer);
            Console.WriteLine("Производитель: " + ManufacturerName);
            Console.WriteLine("Тип фильтра: " + FilterType);
            Console.WriteLine("Выполнение фильтра: " + ExecutingFilter);
            Console.WriteLine("Высота (мм): " + Height);
            Console.WriteLine("Наружный диаметр1 (мм): " + OutsideDiameter1);
            Console.WriteLine("Наружный диаметр2 (мм): " + OutsideDiameter2);
            Console.WriteLine("Диаметр уплотненной прокладки (мм): " + SealedGasketDiameter);
            Console.WriteLine("Внутреняя резьба (мм): " + InternalThread);
            Console.WriteLine("Гарантия: " + Guarantee);
        }
    }
}
