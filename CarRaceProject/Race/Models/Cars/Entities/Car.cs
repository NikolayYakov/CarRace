﻿using Race.Models.Cars.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Race.Models.Cars.Entities
{
    public abstract class Car:ICar
    {
        private string model;
        private int horsePower;
        private int minHorsePower;
        private int maxHorsePower;
        public Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, int maxHorsePower)
        {
            this.minHorsePower = minHorsePower;
            this.maxHorsePower = maxHorsePower;
            Model = model;
            HorsePower = horsePower;
            CubicCentimeters = cubicCentimeters;

        }
        public string Model
        {
            get
            {
                return model;
            }
            protected set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
                }
                model = value;
            }
        }

        public int HorsePower
        {
            get
            {
                return horsePower;
            }
            protected set
            {
                if (value < minHorsePower || value > maxHorsePower)
                {
                    throw new ArgumentException($"Invalid horse power: {value}.");
                }
                horsePower = value;
            }
        }

        public double CubicCentimeters { get; protected set; }

        public abstract double CalculateRacePoints(int laps);
         
         
    }
}
