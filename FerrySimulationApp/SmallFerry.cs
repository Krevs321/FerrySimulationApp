using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    
    public class SmallFerry : Ferry
    {
        public override int Capacity { get; } = 8;
        public override string FerryType => "Small Ferry";
    }
}
