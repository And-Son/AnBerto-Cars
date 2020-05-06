using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class DirectVendedorConfiguracao :
        IEntityTypeConfiguration<DirectVendedor>
    {
        public void Configure(EntityTypeBuilder<DirectVendedor> builder)
        {
            builder.ToTable("DirectVendedor","AndBerto");
            builder.HasKey("idDirectVendedor", "idPublicacao", "idCliente");
            builder.Property(f => f.Mensagem)
                .IsRequired()
                .HasMaxLength(200);
        }
    }
}
