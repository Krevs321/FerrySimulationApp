namespace FerrySimulationApp
{
    public class BigFerry : Ferry
    {
        public override int Capacity { get; } = 6;

        public override string FerryType => "Large Ferry";
        public override char FerryStation => 'L';

        public override int Multiplier { get; set; } = 1;

    }
}
