using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.OppPrinciples.Coupling
{
    public class BadOrder
    {
        public void PlaceOrder()
        {
            BadEmailSender emailSender = new BadEmailSender();
            emailSender.SendEmail("order placed successfully");
        }
    }
}