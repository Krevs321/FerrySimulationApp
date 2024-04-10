namespace FerrySimulationApp
{
    public class VehicleGenerator
    {       
        public static IVehicle GenerateRandomVehicle()
        {
            // Randomly decide the type of vehicle
            int vehicleType = RandomInstance.Instance.Next(1, 5); // Generates a number between 1 and 4

            return vehicleType switch
            {
                1 => new Car(),
                2 => new Van(),
                3 => new Bus(),
                4 => new Truck(),
                _ => throw new InvalidOperationException("Unexpected vehicle type.")
            };
        }
    }
}
