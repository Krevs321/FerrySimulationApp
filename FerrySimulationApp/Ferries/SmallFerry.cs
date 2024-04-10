namespace FerrySimulationApp
{
    
    public class SmallFerry : Ferry
    {
        public override int Capacity { get; } = 8;
        public override string FerryType => "Small Ferry";

        public override char FerryStation => 'S';

        public override int Multiplier { get; set; } = 1;
    }
}
