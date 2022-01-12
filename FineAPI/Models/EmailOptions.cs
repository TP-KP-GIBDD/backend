using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FineAPI.Models
{
    public class EmailOptions
    {
        public const string From = "gorbulkogi@gmail.com";
        public const string Password = "12345678gibdd";
        public const bool IsEnableHtml = true; 
        public const string SmtpDomain = "smtp.gmail.com";
        public const int SmtpPort= 587;
        public const bool EnableSs1 = true;
        public const bool IsBodyHtml = true;
        public const string Name = "GIBDD";
        public const string Smtp= "smtp.gmail.com";
    }
    
}
