using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Composition
{
    public class Car
    {
        private Engine engine = new Engine();
        private Wheels wheels = new Wheels();
        private Chassis chassis = new Chassis();
        private Seats seats = new Seats();

        public void StartCar()
        {
            engine.Start();
            wheels.Rotating();
            chassis.Support();
            seats.Sit();
            Console.WriteLine("Car Started");
        }

    }
}