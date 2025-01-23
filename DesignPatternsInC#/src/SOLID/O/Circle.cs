using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.SOLID.O
{
    public class Circle : Shape
    {
        public double radius{get; set;}
        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}