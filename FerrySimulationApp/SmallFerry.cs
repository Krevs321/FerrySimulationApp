using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class SmallFerry : IFerry
    {
        private List<IVehicle> vehicles = new List<IVehicle>();
        public int Capacity { get; } = 8;
        public int numberOfFerries { get; set; } = 1;

        public bool AddVehicle(IVehicle vehicle)
        {           
            if (vehicles.Count >= Capacity)
            {
                StandardMessages.FerryIsFull("Small Ferry");
                return false;
            }


            VehiclePath.VehicleStation(vehicle.Path.Last());
            Thread.Sleep(1000);
            StandardMessages.AddedToFerry(vehicle, "Small ferry");
            vehicles.Add(vehicle);          
            return true;
        }

        public void Depart()
        {
            Console.WriteLine($"Small Ferry{numberOfFerries} departing with {vehicles.Count} vehicles.");
            numberOfFerries++;
            vehicles.Clear();
        }

        public bool IsReadyToDepart()
        {           
            return vehicles.Count >= Capacity;
        }
    }
}
