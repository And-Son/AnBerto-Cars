using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class AvaliarVendedorConfiguracao :
        IEntityTypeConfiguration<AvaliarVendedor>
    {
        public void Configure(EntityTypeBuilder<AvaliarVendedor> builder)
        {
            builder.ToTable("AvaliarVendedor","AndBerto");
            builder.HasKey("idAvaliacao","idCliente","idPublicacao","idPerfil");
            builder.Property(f => f.Comentario)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(f => f.Nota);
        }
    }
}
