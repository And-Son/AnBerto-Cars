using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class EspecificacoesVeiculoConfiguracao :
        IEntityTypeConfiguration<EspecificacoesVeiculo>
    {
        public void Configure(EntityTypeBuilder<EspecificacoesVeiculo> builder)
        {
            builder.ToTable("EspecificacoesVeiculo","AndBerto");
            builder.HasKey("idEspecificacoesVeiculo", "idPublicacao","idCliente");
            builder.Property(f => f.Modelo)
                .HasMaxLength(10);
            builder.Property(f => f.NomeVeiculo)
                .HasMaxLength(50);
            builder.Property(f => f.Multa);
        }
    }
}
