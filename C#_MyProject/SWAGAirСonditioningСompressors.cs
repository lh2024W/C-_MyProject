using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class SWAGAirСonditioningСompressors : AirСonditioningСompressors
    {
        public SWAGAirСonditioningСompressors(string Name, string Length, string Height, int NumberOfRibs,
            string Pulley, string Weight, string AmountOfOil, string Coolant,
            string Inlet, string Outlet, string CompressorOil)
        {
            this.Name = Name;
            CountryManufacturer = "Германия";
            ManufacturerName = "SWAG";
            this.Length = Length;
            this.Height = Height;
            this.NumberOfRibs = NumberOfRibs;
            this.Pulley = Pulley;
            this.Weight = Weight;
            this.AmountOfOil = AmountOfOil;
            this.Coolant = Coolant;
            this.Inlet = Inlet;
            this.Outlet = Outlet;
            this.CompressorOil = CompressorOil;
        }

        public override string ToString()
        {
            return "Наименование: " + Name + " " + "Страна производитель: " + CountryManufacturer + " " + "Производитель: "
                + ManufacturerName + " " + "Длина (мм): " + Length + " " + "Высота (мм): " + Height + " " + "Количество ребер: "
                + NumberOfRibs + " " + "Шкива (мм): " + Pulley + " " + "Вес (г): " + Weight + " " + "Количество масла (мл): "
                + AmountOfOil + " " + "Хладагент: " + Coolant + " " + "Впускной (мм): " + Inlet + " " + "Выпускной (мм): "
                + Outlet + " " + "Компресорное масло: " + CompressorOil;
        }
    }

}
