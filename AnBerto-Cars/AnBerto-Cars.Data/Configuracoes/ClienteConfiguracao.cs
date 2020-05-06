using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class ClienteConfiguracao : 
        IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Cliente","AndBerto");
            builder.HasKey("idCliente");
            builder.Property(f => f.CPF)
                .HasMaxLength(11);
            builder.Property(f => f.DataNasc);
            builder.Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(150);
            builder.Property(f => f.idTelefone);
            builder.Property(f => f.idEndereco);
        }
    }
}
