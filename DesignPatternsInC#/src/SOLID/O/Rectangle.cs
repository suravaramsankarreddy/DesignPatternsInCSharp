using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.SOLID.O
{
    public class Rectangle: Shape
    {
        public double length{get; set;}

        public double width{get; set;}

        public override double CalculateArea()
        {
            return length*width;
        }
    }
}