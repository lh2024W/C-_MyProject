using C__MyProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C__MyProject
{
    public class NippartsExhaustSystem : ExhaustSystem
    {
        public NippartsExhaustSystem(string Name, string Material, string MetalThickness)
        {
            this.Name = Name;
            CountryManufacturer = "Нидерланды";
            ManufacturerName = "NIPPARTS";
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

