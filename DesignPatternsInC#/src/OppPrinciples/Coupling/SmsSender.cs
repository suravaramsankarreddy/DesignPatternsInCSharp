using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Coupling
{
    public class SmsSender: INotificationService
    {
        public void SendNotification(string message)
        {
            Console.WriteLine("sms message "+ message);
        }
    }
}