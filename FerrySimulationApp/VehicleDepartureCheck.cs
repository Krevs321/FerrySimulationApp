using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class VehicleDepartureCheck
    {
        public static void VehicleDeparture(IFerry ferryType1, IFerry ferryType2)
        {
            // Check if ferries are ready to depart
            if (ferryType1.IsReadyToDepart())
            {
                ferryType1.Depart();
            }

            if (ferryType2.IsReadyToDepart())
            {
                ferryType2.Depart();
            }
        }
    }
}
