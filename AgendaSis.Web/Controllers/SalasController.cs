using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgendaSis.Application.Models.Salas;
using AgendaSis.Application.Services.Salas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AgendaSis.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalasController : ControllerBase
    {
        private readonly ISalaService svc;

        public SalasController(ISalaService service)
        {
            svc = service;
        }

        // GET: api/Salas
        [HttpGet]
        public async Task<IEnumerable<SalaResponseDto>> Get()
        {
            return await svc.GetAllAsync();
        }

        // GET: api/Salas/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Salas
        [HttpPost]
        public async Task<SalaResponseDto> Post([FromBody] SalaRequestDto model)
        {
            var response = await svc.CreateAsync(model);

            return response;
        }

        // PUT: api/Salas/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
