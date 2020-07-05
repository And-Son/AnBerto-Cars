using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class PublicarAnuncioConfiguracao :
        IEntityTypeConfiguration<PublicarAnuncio>
    {
        public void Configure(EntityTypeBuilder<PublicarAnuncio> builder)
        {
            builder.ToTable("PublicarAnuncio","AndBerto");
            builder.HasKey("idPublicacao");
            builder.Property(f => f.Texto)
                .HasMaxLength(150)
                .HasColumnName("Texto");
            builder.Property(f => f.idCliente)
                .HasColumnName("idCliente");
            builder.Property(f => f.ImagemPublic)
                .HasMaxLength(50)
                .HasColumnName("ImagemPublic");
            builder.Property(f => f.Comentar)
                .HasMaxLength(50)
                .HasColumnName("Comentar");
            builder.Property(f => f.TituloAnuncio)
                .HasMaxLength(50)
                .HasColumnName("TituloAnuncio");
            builder.Property(f => f.Curtir)
                .HasColumnName("Curtir");
        }
    }
}
