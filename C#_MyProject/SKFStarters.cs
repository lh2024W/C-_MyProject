using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class SKFStarters : Starters
    {
        public SKFStarters(string Name, string FilterType, string CarBrand, string CarModel, string YearCar,
            int NumberOfTeeth, string Voltage, string Dimensions)
        {
            this.Name = Name;
            CountryManufacturer = "Швеция";
            ManufacturerName = "SKF";
            this.CarBrand = CarBrand;
            this.CarModel = CarModel;
            this.YearCar = YearCar;
            this.NumberOfTeeth = NumberOfTeeth;
            this.Voltage = Voltage;
            this.Dimensions = Dimensions;
        }

        public override string ToString()
        {
            return "Наименование: " + Name + " " + "Страна производитель: " + CountryManufacturer + " " + "Производитель: "
                + ManufacturerName + " " + "Марка автомобиля: " + CarBrand + " " + "Модель автомобиля: " + CarModel + " " +
                "Год выпуска автомобиля: " + YearCar + " " + "Количество зубцов: " + NumberOfTeeth + " " + "Напряжение (В): "
                + Voltage + " " + "Габариты (мм): " + Dimensions;
        }
    }
}
