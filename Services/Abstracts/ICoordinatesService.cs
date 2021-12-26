using DTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services.Abstracts
{
    public interface ICoordinatesService
    {
        Task<IEnumerable<Coordinates>> GetAll();
        Task<Coordinates> GetProtocolById(int Id);
        Task<Coordinates> Create(Coordinates coordinates);
        Task<Coordinates> Update(Coordinates coordinates);
        Task Delete(int Id);
    }
}
