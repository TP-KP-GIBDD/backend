using AvtoAPI.Entities;
using AvtoAPI.Models;
using AvtoAPI.Repositories;
using AvtoAPI.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services
{
    public class AvtoService : IAvtoService
    {
        private readonly IAvtoRepository _avtoRepository;

        public async Task<Avto> Create(Avto avto)
        {
            return await _avtoRepository.Create(avto);
        }

        public async Task DeleteAvto(int id)
        {
            await _avtoRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<Avto>> GetAll()
        {
            return await _avtoRepository.GetAll();
        }

        public async Task<Avto> GetAvtoById(int id)
        {
            return await _avtoRepository.GetAsync(id);
        }

        public async Task<Avto> GetByNumberAvto(string numberAvto)
        {
            return await _avtoRepository.GetByNumberAvto(numberAvto);
        }

        public async Task<Avto> UpdateAvto(Avto avto)
        {
            return await _avtoRepository.UpdateAsync(avto) ;
        }
    }
}
