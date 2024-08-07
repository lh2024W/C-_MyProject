using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class NippartsShockAbsorbers : ShockAbsorbers
    {
        public NippartsShockAbsorbers(string Name, string Accommodation, string Side, string TypeOfFiller,
            int QuantityPerAxle, string Guarantee, string WarrantyIncluded)
        {
            this.Name = Name;
            CountryManufacturer = "Нидерланды";
            ManufacturerName = "NIPPARTS";
            this.Accommodation = Accommodation;
            this.Side = Side;
            this.TypeOfFiller = TypeOfFiller;
            this.QuantityPerAxle = QuantityPerAxle;
            this.Guarantee = Guarantee;
            this.WarrantyIncluded = WarrantyIncluded;
        }

        public override string ToString()
        {
            return "Наименование: " + Name + " " + "Страна производитель: " + CountryManufacturer + " " +
                "Производитель: " + ManufacturerName + " " + "Размещение: " + Accommodation + " " +
                "Сторона: " + Side + " " + "Вид наполнителя: " + TypeOfFiller + " " + "Количество на ось: "
                + QuantityPerAxle + " " + "Гарантия: " + Guarantee + " " + "Гарантия в комплекте: " +
                WarrantyIncluded;
        }
    }
}
