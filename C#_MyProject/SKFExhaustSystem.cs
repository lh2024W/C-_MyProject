using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class SKFExhaustSystem : ExhaustSystem
    {
        public SKFExhaustSystem(string Name, string Accommodation, string Material, string MetalThickness)
        {
            this.Name = Name;
            CountryManufacturer = "Швеция";
            ManufacturerName = "SKF";
            this.Material = Material;
            this.MetalThickness = MetalThickness;
        }

        public override string ToString()
        {
            return "Наименование: " + Name + " " + "Страна производитель: " + CountryManufacturer + " " +
                "Производитель: " + ManufacturerName + " " + "Материал: " + Material + " " +
                "Толщина метала (мм): " + MetalThickness;
        }
    }
}
