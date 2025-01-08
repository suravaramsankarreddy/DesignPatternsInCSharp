using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {   
            Connect();
            Authenticate();
            System.Console.WriteLine("Sending An Email...");
            Disconnect();
        }

        private void Connect()
        {
            System.Console.WriteLine("Connecting To Email Server...");
        }

        private void Authenticate()
        {
            System.Console.WriteLine("Authenticating...");
        }

        private void Disconnect()
        {
            System.Console.WriteLine("DisConnecting From Email Server...");
        }        
    }
}