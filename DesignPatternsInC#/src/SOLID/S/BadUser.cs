using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.SOLID.S
{
    public class BadUser
    {
        public string userName {get; set;}
        public string Email {get; set;}

        public void Register()
        {
            //Register email

            // send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(Email, "Welcome to our Platform!");
        }
    }
}