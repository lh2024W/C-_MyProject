using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__MyProject
{
    public class FebestFactory : IGoodsAbstractFactory
    {
        public Bearings GetBearings(string Name, string Accommodation, string Width1, string Width2, string OutsideDiameter1,
            string OutsideDiameter2, string InnerDiameter1, string InnerDiameter2)
        {
            return new FebestBearings(Name, Accommodation, Width1, Width2, OutsideDiameter1, OutsideDiameter2,
                InnerDiameter1, InnerDiameter2);
        }

        public ShockAbsorbers GetShockAbsorbers(string Name, string Accommodation, string Side, string TypeOfFiller,
            int QuantityPerAxle, string Guarantee, string WarrantyIncluded)
        {
            return new FebestShockAbsorbers(Name, Accommodation, Side, TypeOfFiller, QuantityPerAxle, Guarantee,
                WarrantyIncluded);
        }

        public ExhaustSystem GetExhaustSystem(string Name, string Accommodation, string Material, string MetalThickness)
        {
            return new FebestExhaustSystem(Name, Accommodation, Material, MetalThickness);
        }

        public Filters GetFilters(string Name, string FilterType, string ExecutingFilter, string Height, string OutsideDiameter1,
            string OutsideDiameter2, string SealedGasketDiameter, string InternalThread, string Guarantee)
        {
            return new FebestFilters(Name, FilterType, ExecutingFilter, Height, OutsideDiameter1,
            OutsideDiameter2, SealedGasketDiameter, InternalThread, Guarantee);
        }

        public AirСonditioningСompressors GetAirСonditioningСompressors(string Name, string Length, string Height, int NumberOfRibs,
            string Pulley, string Weight, string AmountOfOil, string Coolant, string Inlet, string Outlet, string CompressorOil)
        {
            return new FebestAirСonditioningСompressors(Name, Length, Height, NumberOfRibs, Pulley, Weight, AmountOfOil, Coolant, Inlet, Outlet, CompressorOil);
        }

        public Starters GetStarters(string Name, string FilterType, string CarBrand, string CarModel, string YearCar,
            int NumberOfTeeth, string Voltage, string Dimensions)
        {
            return new FebestStarters(Name, FilterType, CarBrand, CarModel, YearCar, NumberOfTeeth, Voltage, Dimensions);
        }

        public Springs GetSprings(string Name, string Accommodation, string CarBrand, string CarModel, string Length,
            string Width, string ThicknessInTheCenter)
        {
            return new FebestSprings(Name, Accommodation, CarBrand, CarModel, Length, Width, ThicknessInTheCenter);
        }
    }
}
