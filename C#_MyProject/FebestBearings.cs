using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class FebestBearings : Bearings
    {
        public FebestBearings (string Name, string Accommodation, string Width1, string Width2, string OutsideDiameter1,
            string OutsideDiameter2, string InnerDiameter1, string InnerDiameter2)
            {
                this.Name = Name;
                CountryManufacturer = "Германия";
                ManufacturerName = "FEBEST";
                this.Accommodation = Accommodation;
                this.Width1 = Width1;
                this.Width2 = Width2;
                this.OutsideDiameter1 = OutsideDiameter1;
                this.OutsideDiameter2 = OutsideDiameter2;
                this.InnerDiameter1 = InnerDiameter1;
                this.InnerDiameter2 = InnerDiameter2;
            }

        public override string ToString()
        {
            return "Наименование: " + Name + " " + "Страна производитель: " + CountryManufacturer + " " + "Производитель: "
                + ManufacturerName + " " + "Размещение: " + Accommodation + " " + "Ширина1 (мм): " + Width1 + " " +
                "Ширина2 (мм): " + Width2 + " " + "Наружный диаметр1 (мм): " + OutsideDiameter1 + " " + "Наружный диаметр2 (мм): " +
                OutsideDiameter2 + " " + "Внутрений диаметр1 (мм): " + InnerDiameter1 + " " + "Внутрений диаметр2 (мм): " + InnerDiameter2;
        }

        
    }
}
