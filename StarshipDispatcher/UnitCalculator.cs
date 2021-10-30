using System;
using StarshipDispatcher.Interfaces;

namespace StarshipDispatcher
{
    public class UnitCalculator : IUnitCalculator
    {
        private const double LIGHT_YEAR_TO_ASTRONOMICAL_UNIT_COEFFICIENT = 63241.07708807;
        private const double ASTRONOMICAL_UNIT_TO_LIGHT_YEAR_COEFFICIENT = 1.5812507408869e-5;
        public double FromExternalToInternal(double lightYears) => lightYears * LIGHT_YEAR_TO_ASTRONOMICAL_UNIT_COEFFICIENT;
        public double FromInternalToExternal(double astroUnits) => astroUnits / ASTRONOMICAL_UNIT_TO_LIGHT_YEAR_COEFFICIENT;
    }
}
