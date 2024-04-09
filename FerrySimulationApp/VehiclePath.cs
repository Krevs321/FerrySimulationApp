using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class VehiclePath
    {
        public static void VehicleStation(char locationCode)
        {
            switch (locationCode)
            {
                case 'A':
                    Console.WriteLine("Vehicle last station: Arrival");
                    break;
                case 'G':
                    Console.WriteLine("Vehicle last station: Gas Station");
                    break;                   
                case 'C':
                    Console.WriteLine("Vehicle last station: Customs Inspection");
                    break;                 
                case 'S':
                    Console.WriteLine("Vehicle last station: Small Ferry");
                    break;                  
                case 'L':
                    Console.WriteLine("Vehicle last station: Large Ferry");
                    break;                  
                default:
                    Console.WriteLine("Unknown Location");
                    break;                    
            }            
        }
    }
}
