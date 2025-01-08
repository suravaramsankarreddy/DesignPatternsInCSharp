using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Coupling
{
    public interface INotificationService
    {
        void SendNotification(string message);
    }
}