namespace FerrySimulationApp
{
    public class Van : IVehicle, IRefuelable, ICustoms
    {
        public int Fee => 4;

        public float FuelCapacity => 100;

        public float CurrentFuel { get; set; }
        public bool CargoDoorsOpen { get; private set; } = false;
        public List<char> Path { get; set; }

        public Van()
        {
            CurrentFuel = RandomInstance.Instance.Next(1, (int)FuelCapacity + 1);
            Path = new List<char> { 'A' };
        }

        public void Refuel()
        {
            VehicleRefuling.RefuelVehicle(CurrentFuel, FuelCapacity, Path);
        }

        public void PerformCustomsCheck()
        {
            VehicleCustoms.PerformCustomsCheck(CargoDoorsOpen, Path);
        }
    }
}
