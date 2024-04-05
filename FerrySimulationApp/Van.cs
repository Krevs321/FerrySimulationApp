using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class Van : IVehicle, IRefuelable, ICustoms
    {
        public int Fee => 4;

        public float FuelCapacity => 100;

        public float CurrentFuel { get; set; }
        public bool CargoDoorsOpen { get; private set; } = false;
        public List<char> Path { get; set; }

        public Van()
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

        public void PerformCustomsCheck()
        {
            Console.WriteLine($"Inspection started! Doors are opened: {!CargoDoorsOpen}");
            Thread.Sleep(1500);
            Console.WriteLine($"Inspection Done! Doors are opened: {CargoDoorsOpen}");
            Path.Add('C');
        }
    }
}
