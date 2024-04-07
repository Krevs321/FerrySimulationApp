using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class VehicleAdding
    {
        public bool AddVehicle(IVehicle vehicle)
        {

            if (vehicles.Count >= Capacity)
            {
                StandardMessages.FerryIsFull("Big ferry");
                return false;
            }

            VehiclePath.VehicleStation(vehicle.Path.Last());
            StandardMessages.AddedToFerry(vehicle, "Big ferry");
            vehicles.Add(vehicle);
            return true;
        }
    }
}
