using AgendaSis.Domain.Entidades;
using AgendaSis.Domain.Interfaces;
using AgendaSis.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaSis.Infra.Repositorios
{
    public class PessoaFisicaRepository : GenericRepository<PessoaFisica>, IPessaFisicaRepository
    {
        public PessoaFisicaRepository(MeuContexto dbContext) : base(dbContext)
        {
        }
    }
}
