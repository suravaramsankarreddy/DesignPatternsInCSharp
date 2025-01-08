using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Coupling
{
    public class BadEmailSender
    {
        public void SendEmail(string message)
        {
            System.Console.WriteLine("send email: "+ message);
        }
    }
}