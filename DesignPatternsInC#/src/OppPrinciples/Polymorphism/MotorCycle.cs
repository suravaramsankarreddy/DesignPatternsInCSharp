using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Polymorphism
{
    public class MotorCycle : Vehicle
    {
         public override void Start()
        {
            Console.WriteLine("MotorCycle is Starting");
        }

        public override void Stop()
        {
            Console.WriteLine("MotorCycle Car is stopping");
        }
    }
}