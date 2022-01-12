using AvtoAPI.Entities;
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
        private readonly ICarOwnerRepository _carOwnerRepository;

        public AvtoService(IAvtoRepository avtoRepository, ICarOwnerRepository carOwnerRepository)
        {
            _avtoRepository = avtoRepository;
            _carOwnerRepository = carOwnerRepository;
        }

        public async Task<Avto> Create(Avto avto)
        {
            CarOwner carOwner = new CarOwner();
            
            await _avtoRepository.Create(avto);
            carOwner.AvtoId = avto.Id;
            carOwner.PersonId = avto.PersonId;
            await _carOwnerRepository.Create(carOwner);
            return avto;
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
