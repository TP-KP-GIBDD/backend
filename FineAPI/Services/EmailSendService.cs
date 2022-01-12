using FineAPI.Models;
using FineAPI.Services.Abstract;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace FineAPI.Services
{
    public class EmailSendService : IEmailSendService
    {
        public async Task Send (string Email, string Name, string Surname, string TypeFine, int SumaryFine )
        {
            MailAddress From = new MailAddress(EmailOptions.From, EmailOptions.Name);
            MailAddress To = new MailAddress(Email, Name);
            MailMessage m = new MailMessage(From, To); // "gorbulkogi+u1@gmail.com"
            m.Subject = "Оплатите штраф";
            m.Body = $"<h2>Здравствуйте, {Name} {Surname}, перейдите по ссылке и оплатите штраф. {TypeFine}. Сумма штрафа: {SumaryFine} рублей </h2>";
            m.IsBodyHtml = EmailOptions.IsBodyHtml;
            SmtpClient smtp = new SmtpClient(EmailOptions.Smtp, EmailOptions.SmtpPort);
            smtp.Credentials = new NetworkCredential(EmailOptions.From, EmailOptions.Password);
            smtp.EnableSsl = EmailOptions.EnableSs1;
            await smtp.SendMailAsync(m);
        }
    }
}
