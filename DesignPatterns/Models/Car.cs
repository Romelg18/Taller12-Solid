using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.Models
{
    public class Car : Vehicle
    {
        public override int Tires { get => 4; }
        public int Year { get; internal set; }

        public Car(string color, string brand, string model, int Year) : base(color, brand, model)
        {

        }
    }
}
