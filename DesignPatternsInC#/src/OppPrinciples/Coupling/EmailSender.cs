using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Coupling
{
    public class EmailSender : INotificationService
    {
        public void SendNotification(string message)
        {
            System.Console.WriteLine("SendEmail: " + message);
        }
    }
}