using AgendaSis.Domain.Entidades;
using AgendaSis.Domain.Interfaces;
using AgendaSis.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaSis.Infra.Repositorios
{
    public class AgendaRepository : GenericRepository<Agenda>, IAgendaRepository
    {
        public AgendaRepository(MeuContexto dbContext) 
            : base(dbContext)
        {
        }
    }
}
