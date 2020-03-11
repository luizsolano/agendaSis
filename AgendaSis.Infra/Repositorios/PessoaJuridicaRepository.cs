using AgendaSis.Domain.Entidades;
using AgendaSis.Domain.Interfaces;
using AgendaSis.Infra.Contexto;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaSis.Infra.Repositorios
{
    public class PessoaJuridicaRepository : GenericRepository<PessoaJuridica>, IPessoaJuridicaRepository
    {
        public PessoaJuridicaRepository(MeuContexto dbContext) : base(dbContext)
        {
        }
    }
}
