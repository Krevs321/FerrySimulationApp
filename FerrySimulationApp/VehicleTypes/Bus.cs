namespace FerrySimulationApp
{
    public class Bus : IVehicle, IRefuelable
    {
        public int Fee => 5;

        public float FuelCapacity => 100;

        public float CurrentFuel { get; set; }
        public List<char> Path { get; set; }

        public Bus()
        {
            CurrentFuel = RandomInstance.Instance.Next(1, (int)FuelCapacity + 1);
            Path = new List<char> { 'A' };
        }

        public void Refuel()
        {
            CurrentFuel = VehicleRefuling.RefuelVehicle(CurrentFuel, FuelCapacity, Path);
        }
    }
}
