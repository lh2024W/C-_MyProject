using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class NippartsSprings : Springs
    {
        public NippartsSprings(string Name, string Accommodation, string CarBrand, string CarModel, string Length,
            string Width, string ThicknessInTheCenter)
        {
            this.Name = Name;
            CountryManufacturer = "Нидерланды";
            ManufacturerName = "NIPPARTS";
            this.Accommodation = Accommodation;
            this.CarBrand = CarBrand;
            this.CarModel = CarModel;
            this.Length = Length;
            this.Width = Width;
            this.ThicknessInTheCenter = ThicknessInTheCenter;
        }

        public override string ToString()
        {
            return "Наименование: " + Name + " " + "Страна производитель: " + CountryManufacturer + " " + "Производитель: "
                + ManufacturerName + " " + "Размещение: " + Accommodation + " " + "Марка автомобиля: " + CarBrand + " " +
                "Модель автомобиля: " + CarModel + " " + "Длина (мм): " + Length + " " + "Ширина (мм): " + Width + " " +
                "Толщина по центру (мм): " + ThicknessInTheCenter;
        }
      
    }
}
