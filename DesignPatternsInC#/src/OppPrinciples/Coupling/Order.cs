using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Coupling
{
    public class Order
    {
        private readonly INotificationService notificationService;

        public Order(INotificationService notificationService)
        {
            this.notificationService = notificationService;
        }

        public void PlaceOrder()
        {
            notificationService.SendNotification("Order Placed sucessfully...");
        }
    }
}