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
                .HasMaxLength(11)
                .HasColumnName("CPF");
            builder.Property(f => f.DataNasc)
                .HasColumnName("DataNasc");
            builder.Property(f => f.Nome)
                .IsRequired()
                .HasMaxLength(150)
                .HasColumnName("Nome");
            builder.Property(f => f.idTelefone)
                .HasColumnName("idTelefone");
            builder.Property(f => f.idEndereco)
                .HasColumnName("idEndereco");
            builder.Property(f => f.UsuarioLogin)
                .HasColumnName("UsuarioLogin");
            builder.Property(f => f.SenhaLogin)
                .HasColumnName("SenhaLogin");
        }
    }
}
