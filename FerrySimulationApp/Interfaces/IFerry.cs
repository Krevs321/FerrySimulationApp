namespace FerrySimulationApp
{
    public interface IFerry
    {
        
        bool AddVehicle(IVehicle vehicle);
        void Depart();
        bool IsReadyToDepart();
    }
}
