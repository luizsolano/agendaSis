﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgendaSis.Application.Models.Generos;

namespace AgendaSis.Application.Services.Generos
{
    public class GeneroFakeService : IGeneroService
    {
        private List<GeneroResponseDto> Lista;

        public GeneroFakeService()
        {
            Lista = new List<GeneroResponseDto>
            {
                new GeneroResponseDto { Id = 1, Nome = "Masculino"},
                new GeneroResponseDto { Id = 2, Nome = "Feminino"},
                new GeneroResponseDto { Id = 3, Nome = "Trans"},
                new GeneroResponseDto { Id = 4, Nome = "Outro"}
            };
        }

        public async Task<GeneroResponseDto> CreateAsync(GeneroRequestDto model)
        {

            var genero = new GeneroResponseDto
            {
                Id = Lista.Count + 1,
                Nome = model.Nome
            };

            await Task.Run(() => Console.WriteLine("Inclui o genero"));

            return genero;
        }

        public async Task DeleteAsync(int id)
        {
            await Task.Run(() => Console.WriteLine("Exclui o genero" + id));

        }

        public async Task<List<GeneroResponseDto>> GetAllAsync()
        {
            await Task.Run(() => Console.WriteLine("Listei o genero"));
            return Lista;
        }

        public async Task<GeneroResponseDto> GetById(int id)
        {
            await Task.Run(() => Console.WriteLine("Listei o genero"));
            return Lista.FirstOrDefault(f => f.Id == id);
        }
    }
}
