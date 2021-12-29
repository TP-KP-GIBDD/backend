using DTP.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DTP.Services.Abstracts
{
    public interface IPlaceViolationService
    {
        Task<IEnumerable<PlaceViolation>> GetAll();
        Task<PlaceViolation> GetPlaceViolationById(int Id);
        Task<PlaceViolation> Create(PlaceViolation place);
        Task<PlaceViolation> Update(PlaceViolation place);
        Task Delete(int Id);
    }
}
