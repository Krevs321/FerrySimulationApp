using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public abstract class Ferry : IFerry, IMoneyCollecting
    {
        private List<IVehicle> Vehicles = [];
        public abstract int Capacity { get; }
        public int NumberOfFerries { get; set; } = 1;
        public int MoneyCollected { get; set; } = 0;
        public float MoneyCollectedByInsector { get; set; } = 0;
        public abstract string FerryType { get; }

        public bool AddVehicle(IVehicle vehicle)
        {
            MoneyCollected += vehicle.Fee;      
            MoneyCollectedByInsector += (vehicle.Fee * 0.1f);
            return VehicleAdding.AddVehicle(vehicle, Vehicles, Capacity, FerryType, 'L');
        }

        public void Depart()
        {
            Console.WriteLine($"Large Ferry #{NumberOfFerries} departing with {Vehicles.Count} vehicles. Total money collected: {MoneyCollected} Euros. " +
                                $"Total Money collected by Inspector: {Math.Round(MoneyCollectedByInsector, 2)} Euros");           
            MoneyCollected = 0;
            MoneyCollectedByInsector = 0;
            NumberOfFerries++;
            Vehicles.Clear();
        }

        public bool IsReadyToDepart()
        {           
            return Vehicles.Count >= Capacity;
        }
    }
}
