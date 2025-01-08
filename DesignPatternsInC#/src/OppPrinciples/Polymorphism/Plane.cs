using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Polymorphism
{
    public class Plane : Vehicle
    {
        public int NumberOfDoors {get; set;}

        public override void Start()
        {
            Console.WriteLine("Car is Starting");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping");
        }
    }
}