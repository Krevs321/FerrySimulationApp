namespace FerrySimulationApp
{
    public class GameLoop
    {
        private IFerry smallFerry = new SmallFerry();
        private IFerry bigFerry = new BigFerry();
        //private IFerry vipFerry = new VipFerry();

        public void Run()
        {
            while(true)
            {
                var vehicle = VehicleGenerator.GenerateRandomVehicle();

                StandardMessages.VehicleArrival(vehicle);

                VehicleProcessFlow.ProcessVehicle(vehicle);

                bool addedToFerry = vehicle is Truck || vehicle is Bus ? bigFerry.AddVehicle(vehicle) : smallFerry.AddVehicle(vehicle);
                                    //vehicle is Car || vehicle is Van ?  smallFerry.AddVehicle(vehicle);
                                    //vipFerry.AddVehicle(vehicle);

                StandardMessages.VehicleDenied(vehicle, addedToFerry);

                VehicleDepartureCheck.VehicleDeparture(smallFerry, bigFerry );

                Thread.Sleep(2000);
            }
        }
    }
}