using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FineAPI.Models
{
    public class EmailOptions
    {
        public const string From = "gorbulkodi@gamail.com";
        public const string Password = "";
        public const bool IsEnableHtml = true; 
        public const string SmtpDomain = "...gmail.com";
        public const int SmtpPort= 557;
        public const bool EnableSs1 = true;
        public const bool IsBodyHtml = true;
        public const string Name = "GIBDD";
        public const string Smtp= "smtp.gmail.com";
    }
    
}
