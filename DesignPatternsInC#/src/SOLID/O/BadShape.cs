using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.SOLID.O
{
    public class BadShape
    {
        /*if new Shape is added like Triangle we have make changes in entire class, which is keep
        on change code and all existing switch logic as well. which is not a better approach
        */
        public ShapeType type {get; set;}
        public double radius {get; set;}
        public double length {get; set;}
        public double width {get; set;}

        public double CalculateArea()
        {
            switch(type){

                case ShapeType.Circle:
                    return Math.PI * Math.Pow(radius, 2);
                case ShapeType.Rectangle:
                    return length * width;
                default:
                    throw new InvalidOperationException("Unsupportred Shape Type");
            }
        }

    }
}