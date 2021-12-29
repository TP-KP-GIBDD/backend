using AvtoAPI.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AvtoAPI.Services.Abstracts
{
    public interface IColorAvtoService
    {
        Task<ColorAvto> GetColorAvtoById(int id);
        Task<IEnumerable<ColorAvto>> GetAll();
        Task<ColorAvto> Create(ColorAvto colorAvto);
        Task<ColorAvto> UpdateColorAvto(ColorAvto colorAvto);
        Task DeleteColorAvto(int id);
    }
}
