using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    internal class VehicleProcessFlow
    {
        public static void ProcessVehicle(IVehicle vehicle)
        {
            // Directly call Refuel on vehicles that are IRefuelable
            if (vehicle is IRefuelable refuelableVehicle)
            {
                refuelableVehicle.Refuel();
            }

            // Other processing steps, like customs checks for applicable vehicles
            if (vehicle is ICustoms customsCheckable)
            {
                customsCheckable.PerformCustomsCheck();
            }
        }
    }
}
