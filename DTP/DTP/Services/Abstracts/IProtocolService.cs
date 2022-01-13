using DTP.Entities;
using DTP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DTP.Services.Abstracts
{
    public interface IProtocolService
    {
        Task<IEnumerable<Protocol>> GetAll();
        Task<Protocol> GetProtocolById(int Id);
        Task<IEnumerable<Protocol>> GetProtocolByIdentifier(int identifier);
        Task<IEnumerable<Protocol>> GetProtocolByInspector(int inspectorId);
        Task<IEnumerable<Protocol>> GetProtocolByAvto(int avtoId);
        Task<IEnumerable<Protocol>>GetProtocolByTypeViolation(int typeviolation);
        void Create(ProtocolRequest model);
    }
}
