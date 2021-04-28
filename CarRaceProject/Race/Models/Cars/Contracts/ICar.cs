using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models.Cars.Contracts
{
    public interface ICar
    {
        string Model { get; }

        int HorsePower { get; }

        double CubicCentimeters { get; }

        double CalculateRacePoints(int laps);
    }
}
