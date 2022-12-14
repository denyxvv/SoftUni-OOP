using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public interface IVehicle
    { 
        double FuelQuantity { get;}
        double FuelConsumptionInLitresKM { get;}

        string Drive(double distance);
        void Distance(double litres);
        
    }
}
