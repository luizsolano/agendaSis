using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AgendaSis.Infra.Contexto
{
    public class MeuContexto : DbContext
    {
        public MeuContexto([NotNullAttribute] DbContextOptions options) 
            : base(options)
        {
        }

        public MeuContexto() { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuContexto).Assembly);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseNpgsql("MinhaStringConexao");
            }
        }
    }
}
