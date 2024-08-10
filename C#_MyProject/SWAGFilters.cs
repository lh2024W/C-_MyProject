using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class SWAGFilters : Filters
    {
        public SWAGFilters(string Name, string FilterType, string ExecutingFilter, string Height, string OutsideDiameter1,
            string OutsideDiameter2, string SealedGasketDiameter, string InternalThread, string Guarantee)
        {
            this.Name = Name;
            CountryManufacturer = "Германия";
            ManufacturerName = "SWAG";
            this.FilterType = FilterType;
            this.ExecutingFilter = ExecutingFilter;
            this.Height = Height;
            this.OutsideDiameter1 = OutsideDiameter1;
            this.OutsideDiameter2 = OutsideDiameter2;
            this.SealedGasketDiameter = SealedGasketDiameter;
            this.InternalThread = InternalThread;
            this.Guarantee = Guarantee;
        }

        public override string ToString()
        {
            return "Наименование: " + Name + " " + "Страна производитель: " + CountryManufacturer + " " + "Производитель: "
                + ManufacturerName + " " + "Тип фильтра: " + FilterType + " " + "Выполнение фильтра: " + ExecutingFilter + " " +
                "Высота (мм): " + Height + " " + "Наружный диаметр1 (мм): " + OutsideDiameter1 + " " + "Наружный диаметр2 (мм): " +
                OutsideDiameter2 + " " + "Диаметр уплотненной прокладки (мм): " + SealedGasketDiameter + " " +
                "Внутреняя резьба (мм): " + InternalThread + " " + "Гарантия: " + Guarantee;
        }
    }
}
