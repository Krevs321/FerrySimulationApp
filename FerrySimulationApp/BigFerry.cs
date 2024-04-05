using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class BigFerry : IFerry
    {
        private List<IVehicle> vehicles = new List<IVehicle>();
        public int Capacity { get; } = 6;
        public int numberOfFerries { get; set; } = 1;

        public bool AddVehicle(IVehicle vehicle)
        {          

            if (vehicles.Count >= Capacity)
            {
                StandardMessages.FerryIsFull("Big ferry");
                return false;
            }

            VehiclePath.VehicleStation(vehicle.Path.Last());     
            Thread.Sleep(1000);
            StandardMessages.AddedToFerry(vehicle, "Big ferry");
            vehicles.Add(vehicle);           
            return true;
        }

        public void Depart()
        {            
            Console.WriteLine($"Big Ferry{numberOfFerries} departing with {vehicles.Count} vehicles.");
            numberOfFerries++;
            vehicles.Clear(); 
        }

        public bool IsReadyToDepart()
        {
           
            return vehicles.Count >= Capacity;
        }
    }
}
