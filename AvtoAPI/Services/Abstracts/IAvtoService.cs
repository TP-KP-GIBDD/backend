using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IAvtoService
    {
        Task<Avto> GetAvtoById(int id);
        Task<IEnumerable<Avto>> GetAll();
        Task<Avto> Create(Avto avto);
        Task<Avto> UpdateAvto(Avto avto);
        Task DeleteAvto(int id);
        Task<Avto> GetByNumberAvto(string numberAvto);
    }
}
