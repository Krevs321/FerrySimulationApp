namespace FerrySimulationApp
{
    public class VipFerry : Ferry
    {
        public override int Capacity { get; } = 3;

        public override string FerryType => "VIP Ferry";
        public override char FerryStation => 'V';

        public override int Multiplier { get; set; } = 2;

    }
}
