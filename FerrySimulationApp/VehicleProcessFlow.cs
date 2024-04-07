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
            // Directly call Refuel on vehicles that implemnt IRefuelable
            if (vehicle is IRefuelable refuelableVehicle)
            {
                refuelableVehicle.Refuel();
            }

            // Directly call PerformCustomsCheck on vehicles that implemnt ICustoms
            if (vehicle is ICustoms customsCheckable)
            {
                customsCheckable.PerformCustomsCheck();
            }
        }
    }
}
