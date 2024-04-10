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
