using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class VehicleRefuling
    {
        public static float RefuelVehicle(float CurrentFuel, float FuelCapacity, List<char> Path)
        {
            Console.WriteLine($"Current vehicle fuel: {CurrentFuel}.");
            if (CurrentFuel < 10)
            {
                Console.WriteLine($"Refueling vehicle.");       
                Path.Add('G');
                Thread.Sleep(500);
                return CurrentFuel + FuelCapacity;
            }
            Thread.Sleep(1000);
            return CurrentFuel;
        }
    }
}
