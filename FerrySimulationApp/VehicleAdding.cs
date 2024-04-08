﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class VehicleAdding
    {
        public static bool AddVehicle(IVehicle vehicle, List<IVehicle> vehicles, int Capacity, string FerryType)
        {

            if (vehicles.Count >= Capacity)
            {
                StandardMessages.FerryIsFull(FerryType);
                return false;
            }

            VehiclePath.VehicleStation(vehicle.Path.Last());          
            StandardMessages.AddedToFerry(vehicle, FerryType);
            vehicles.Add(vehicle);
            return true;
        }
    }
}
