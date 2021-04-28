using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models.Cars.Entities
{
    public class SportsCar:Car
    {
        public SportsCar(string model, int horsePower)
            : base(model, horsePower, 3000, 250, 450)
        {

        }
        public override double CalculateRacePoints(int laps)
        {
            return CubicCentimeters / HorsePower * laps * 1.1;
        }
    }
}
