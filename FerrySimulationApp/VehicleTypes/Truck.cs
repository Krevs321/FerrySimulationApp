namespace FerrySimulationApp
{
    public class Truck : IVehicle, IRefuelable, ICustoms
    {
        public int Fee => 6;

        public float FuelCapacity => 100;

        public float CurrentFuel { get; set; }
        public bool CargoDoorsOpen { get; private set; } = false;
        public List<char> Path { get; set; }


        public Truck()
        {
            CurrentFuel = RandomInstance.Instance.Next(1, (int)FuelCapacity + 1);
            Path = new List<char> { 'A' };
        }

        public void Refuel()
        {
            CurrentFuel = VehicleRefuling.RefuelVehicle(CurrentFuel, FuelCapacity, Path);
        }

        public void PerformCustomsCheck()
        {
            VehicleCustoms.PerformCustomsCheck(CargoDoorsOpen, Path);
        }
    }
}
