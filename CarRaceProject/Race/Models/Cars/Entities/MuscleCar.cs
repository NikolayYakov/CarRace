using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models.Cars.Entities
{
    public class MuscleCar:Car
    {
        public MuscleCar(string model, int horsePower)
            : base(model, horsePower, 5000, 400, 600)
        {

        }
        public override double CalculateRacePoints(int laps)
        {
            return CubicCentimeters / HorsePower * laps * 0.80;
        }
    }
}
