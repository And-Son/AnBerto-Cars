using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class FavoritosConfiguracao :
        IEntityTypeConfiguration<Favoritos>
    {
        public void Configure(EntityTypeBuilder<Favoritos> builder)
        {
            builder.ToTable("Favoritos","AndBerto");
            builder.HasKey("idSalvos");
            builder.Property(f => f.idCliente);
            builder.Property(f => f.idPublicacao);
        }
    }
}
