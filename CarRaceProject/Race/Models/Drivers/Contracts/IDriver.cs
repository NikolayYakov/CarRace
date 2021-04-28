using Race.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models.Drivers.Contracts
{
    public interface IDriver
    {
        string Name { get; }

        ICar Car { get; }

        int NumberOfWins { get; }

        bool CanParticipate { get; }

        void WinRace();

        void AddCar(ICar car);
    }
}
