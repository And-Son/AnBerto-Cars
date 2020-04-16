using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    class EnderecoConfiguracao : 
        IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco","AndBerto");
            builder.HasKey("idEndereco");
            builder.Property(f => f.Bairro)
                .HasMaxLength(50);
            builder.Property(f => f.Rua)
                .HasMaxLength(50);
            builder.Property(f => f.Cidade)
                .HasMaxLength(50);
            builder.Property(f => f.Numero);
            builder.Property(f => f.CEP);
        }
    }
}
