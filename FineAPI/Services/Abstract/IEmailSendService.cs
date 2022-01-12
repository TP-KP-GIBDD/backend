using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FineAPI.Services.Abstract
{
    interface IEmailSendService
    {
        public Task Send(string Email, string Name, string Surname, string TypeFine, int SumaryFine);
    }
}
