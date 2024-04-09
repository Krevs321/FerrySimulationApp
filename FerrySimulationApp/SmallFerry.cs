using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class SmallFerry : IFerry, IMoneyCollecting
    {
        private List<IVehicle> vehicles = new List<IVehicle>();
        public int Capacity { get; } = 8;
        public int numberOfFerries { get; set; } = 1;

        public int MoneyCollected { get; set; } = 0;
        public float MoneyCollectedByInsector { get; set; } = 0;

        public bool AddVehicle(IVehicle vehicle)
        {
            MoneyCollected += vehicle.Fee;
            MoneyCollectedByInsector += (vehicle.Fee * 0.1f);           
            return VehicleAdding.AddVehicle(vehicle, vehicles, Capacity, "Small Ferry", 'S');
        }

        public void Depart()
        {
            Console.WriteLine($"Small Ferry #{numberOfFerries} departing with {vehicles.Count} vehicles. Total money collected: {MoneyCollected} Euros. " +
                                $"Total Money collected by Inspector: {Math.Round(MoneyCollectedByInsector, 2)} Euros");       
            MoneyCollected = 0;
            MoneyCollectedByInsector = 0;
            numberOfFerries++;
            vehicles.Clear();
        }

        public bool IsReadyToDepart()
        {           
            return vehicles.Count >= Capacity;
        }
    }
}
