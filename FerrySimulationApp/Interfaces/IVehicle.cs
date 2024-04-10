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
