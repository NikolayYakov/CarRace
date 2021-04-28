using Race.Models.Drivers.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models.Races.Contracts
{
    public interface IRace
    {
        string Name { get; }

        int Laps { get; }

        IReadOnlyCollection<IDriver> Drivers { get; }

        void AddDriver(IDriver driver);
    }
}
