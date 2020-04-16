using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using AnBertoCars.Dominio;

namespace AnBertoCars.Data.Configuracoes
{
    public class TelefoneConfiguracao :
        IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("Telefone","AndBerto");
            builder.HasKey("idTelefone");
            builder.Property(f => f.DDD);
            builder.Property(f => f.NumeroTel);
        }
    }
}
