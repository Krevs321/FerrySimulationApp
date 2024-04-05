using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public interface IFerry
    {
        bool AddVehicle(IVehicle vehicle);
        void Depart();
        bool IsReadyToDepart();
    }
}
