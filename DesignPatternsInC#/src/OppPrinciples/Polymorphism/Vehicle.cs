using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Polymorphism
{
    public class Vehicle
    {      
        public string Brand {get; set;}
        public string Model {get; set;}
        public int Year {get; set;}

        public virtual void Start()
        {
            Console.WriteLine("Vehicle is Starting");
        }

        public virtual void Stop()
        {
            Console.WriteLine("Vehicle is Stopping");
        }
    }
} 
   