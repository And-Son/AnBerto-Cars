using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class GruposConfiguracao : 
        IEntityTypeConfiguration<Grupos>
    {
        public void Configure(EntityTypeBuilder<Grupos> builder)
        {
            builder.ToTable("Grupos","AndBerto");
            builder.HasKey("idGrupo");
            builder.Property(f => f.QuantidadeMaxima);
            builder.Property(f => f.idCliente);
            builder.Property(f => f.idPerfil);
            builder.Property(f => f.Mensagens)
                .HasMaxLength(50);
        }
    }
}
