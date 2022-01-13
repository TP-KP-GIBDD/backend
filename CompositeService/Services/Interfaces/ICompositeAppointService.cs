using CompositeService.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompositeService.Services.Interfaces
{
    public interface ICompositeAppointService
    {
        CarOwnerRegAppoint GetRegAppointById(int id);

        List<CarOwnerRegAppoint> GetAllRegAppoint();
    }
}
