using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public interface IGoodsAbstractFactory
    {
        Bearings GetBearings(string Name, string Accommodation, string Width1, string Width2, string OutsideDiameter1,
            string OutsideDiameter2, string InnerDiameter1, string InnerDiameter2);
        ShockAbsorbers GetShockAbsorbers(string Name, string Accommodation, string Side, string TypeOfFiller,
            int QuantityPerAxle, string Guarantee, string WarrantyIncluded);
        ExhaustSystem GetExhaustSystem(string Name, string Material, string MetalThickness);
        Filters GetFilters(string Name, string FilterType, string ExecutingFilter, string Height, string OutsideDiameter1,
            string OutsideDiameter2, string SealedGasketDiameter, string InternalThread, string Guarantee);
        AirСonditioningСompressors GetAirСonditioningСompressors(string Name, string Length, string Height, int NumberOfRibs,
            string Pulley, string Weight, string AmountOfOil, string Coolant, string Inlet, string Outlet, string CompressorOil);
        Starters GetStarters(string Name, string CarBrand, string CarModel, string YearCar,
            int NumberOfTeeth, string Voltage, string Dimensions);
        Springs GetSprings(string Name, string Accommodation, string CarBrand, string CarModel, string Length,
            string Width, string ThicknessInTheCenter);
    }
}
