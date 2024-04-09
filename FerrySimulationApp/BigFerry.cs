using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public class BigFerry : Ferry
    {
        public override int Capacity { get; } = 6;

        public override string FerryType => "Large Ferry";
    }
}
