using DTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services.Abstracts
{
    public interface IProtocolService
    {
        Task<IEnumerable<Protocol>> GetAll();
        Task<Protocol> GetProtocolById(int Id);
        Task<Protocol> GetByAddress(string address);
        Task<Protocol> Create(Protocol protocol);
        Task<Protocol> Update(Protocol protocol);
        Task Delete(int Id);
    }
}
