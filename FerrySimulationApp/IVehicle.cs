using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public interface IVehicle
    {
        int Fee { get; }
        float FuelCapacity { get; }
        float CurrentFuel { get; set; }
        List<char> Path { get; set; }
    }
}
