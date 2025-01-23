using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.SOLID.L
{
    public class Rectangle : Shape
    {
        public virtual double width{get; set;}
        public virtual double height{get; set;}
        public override double area => width * height;
    }
}