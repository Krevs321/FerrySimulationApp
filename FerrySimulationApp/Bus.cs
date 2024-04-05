using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class Bus : IVehicle, IRefuelable
    {
        public int Fee => 5;

        public float FuelCapacity => 100;

        public float CurrentFuel { get; set; }
        public List<char> Path { get; set; }

        public Bus()
        {
            CurrentFuel = RandomInstance.Instance.Next(1, (int)FuelCapacity + 1);

            Path = new List<char> { 'A' };
        }

        public void Refuel()
        {
            if (CurrentFuel < 10)
            {
                Console.WriteLine($"Refueling {GetType().Name}.");
                CurrentFuel = FuelCapacity;
                Path.Add('G');
            }
        }
    }
}
