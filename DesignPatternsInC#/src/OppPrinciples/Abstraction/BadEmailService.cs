using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Abstraction
{
    public class BadEmailService
    {
        public void SendEmail()
        {
            System.Console.WriteLine("Sending An Email...");
        }

         public void Connect()
        {
            System.Console.WriteLine("Connecting To Email Server...");
        }

         public void Authenticate()
        {
            System.Console.WriteLine("Authenticating...");
        }

         public void Disconnect()
        {
            System.Console.WriteLine("DisConnecting From Email Server...");
        }
    }
}