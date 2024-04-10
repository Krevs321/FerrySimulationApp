namespace FerrySimulationApp
{
    public class Car : IVehicle, IRefuelable
    {
        public int Fee => 3;

        public float FuelCapacity => 100;

        public float CurrentFuel { get; set; }
        public List<char> Path { get; set; }

        public Car()
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
