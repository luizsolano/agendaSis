using AgendaSis.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaSis.Infra.Mapeamento
{
    public class PessoaJuridicaMapping : IEntityTypeConfiguration<PessoaJuridica>
    {
        public void Configure(EntityTypeBuilder<PessoaJuridica> builder)
        {
            builder
               .Property(p => p.DataAbertura)
               .HasColumnName("DataAbertura")
               .IsRequired();
            builder
                .Property(p => p.Cnpj)
                .HasColumnName("CNPJ")
                .HasMaxLength(14)
                .IsRequired();
            builder
                .Property(p => p.RazaoSocial)
                .HasColumnName("RazaoSocial")
                .HasMaxLength(300)
                .IsRequired();
            builder
                .HasBaseType<Pessoa>();
        }
    }
}
