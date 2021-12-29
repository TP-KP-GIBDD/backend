using AvtoAPI.Entities;
using AvtoAPI.Repositories.Abstracts;
using AvtoAPI.Services.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services
{
    public class ColorAvtoService : IColorAvtoService
    {
        private readonly IColorAvtoRepository _colorAvtoRepository;

        public ColorAvtoService(IColorAvtoRepository colorAvtoRepository)
        {
            _colorAvtoRepository = colorAvtoRepository;
        }

        public async Task<ColorAvto> Create(ColorAvto colorAvto)
        {
            return await _colorAvtoRepository.Create(colorAvto);
        }

        public async Task DeleteColorAvto(int id)
        {
            await _colorAvtoRepository.GetAsync(id);
        }

        public async Task<IEnumerable<ColorAvto>> GetAll()
        {
            return await _colorAvtoRepository.GetAll();
        }

        public async Task<ColorAvto> GetColorAvtoById(int id)
        {
            return await _colorAvtoRepository.GetAsync(id);
        }

        public async Task<ColorAvto> UpdateColorAvto(ColorAvto colorAvto)
        {
            return await _colorAvtoRepository.UpdateAsync(colorAvto);
        }
    }
}
