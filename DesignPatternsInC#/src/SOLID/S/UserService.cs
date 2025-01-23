using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsInC_.src.SOLID.S
{
    public class UserService
    {
        public void Register(User user)
        {
            //Register email

            // send email
            EmailSender emailSender = new EmailSender();
            emailSender.SendEmail(user.Email, "Welcome to our Platform!");
        }
    }
}