using SportStoreDomain.Abstract;
using SportStoreDomain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStoreDomain.Concrete
{
    public class EmailSettings
    {
        public string MailToAddress = "boonen.bastien@gmail.com";
        public string MailFromAddress = "sportstore@example.com";
        public bool UseSsl = true;
        public string Username = "MySmtpUserName";
        public string Password = "MySmtpPassword";
        public string ServerName = "smtp.example.com";
        public int ServerPort = 587;
        public bool WriteAsFile = false;
        public string FileLocation = "";
    }

    public class EmailOrderProcessor : IOrderProcessor
    {
        private EmailSettings emailSettings;

        public EmailOrderProcessor(EmailSettings settings)
        {
            emailSettings = settings;
        }

        public void ProcessOrder(Cart cart, ShippingDetails shippingDetails)
        {
            // TODO : implement method
        }
    }
}
