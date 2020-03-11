using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaSis.Domain.Entidades
{
    public class Genero : BaseEntity
    {
        protected Genero() { }

        public Genero(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; protected set; }
    }
}
