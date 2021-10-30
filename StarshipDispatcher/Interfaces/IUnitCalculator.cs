using System;

namespace StarshipDispatcher.Interfaces
{
    public interface IUnitCalculator
    {
        double FromExternalToInternal(double input);
        double FromInternalToExternal(double input);
    }
}
