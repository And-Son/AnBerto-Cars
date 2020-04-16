using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class FotoPerfilConfiguracao :
        IEntityTypeConfiguration<FotoPerfil>
    {
        public void Configure(EntityTypeBuilder<FotoPerfil> builder)
        {
            builder.ToTable("FotoPerfil", "AndBerto");
            builder.HasKey("idFotoPerfil", "idCliente", "idPerfil");
            builder.Property(f => f.EnderecoFoto)
                .HasMaxLength(150);
        }
    }
}
