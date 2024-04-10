namespace FerrySimulationApp
{
    public class StandardMessages
    {
        public static void FerryIsFull(string ferryType)
        {
            Console.WriteLine($"{ferryType} is full. Cannot add more vehicles.");
        }

        public static void AddedToFerry(IVehicle vehicle, string ferryType)
        {
            Console.WriteLine($"{vehicle.GetType().Name} added to { ferryType }.");
        }

        public static void VehicleArrival(IVehicle vehicle)
        {
            Console.WriteLine($"{vehicle.GetType().Name} ARRIVED");
        }
        public static void VehicleDenied(IVehicle vehicle, bool addedToFerry)
        {
            if(!addedToFerry)
                Console.WriteLine($"{vehicle.GetType().Name} could not be added to a ferry. Waiting for the next available ferry.");
        }
    }
}
