using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FerrySimulationApp
{
    public interface IMoneyCollecting
    {
        int MoneyCollected { get; set; }
        float MoneyCollectedByInsector { get; set; }
    }
}
