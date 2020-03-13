using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using AgendaSis.Application.Models.Generos;
using AgendaSis.Application.Models.Salas;
using AgendaSis.Domain.Entidades;

namespace AgendaSis.Application.Services.Generos
{
    public interface IGeneroService
    {
        Task<List<GeneroResponseDto>> GetAllAsync();
        Task<GeneroResponseDto> CreateAsync(GeneroRequestDto model);
        Task<GeneroResponseDto> GetById(int id);
        Task DeleteAsync(int id);
    }
}
