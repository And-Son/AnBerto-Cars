using System;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio;
using AnBertoCars.Data.Configuracoes;

namespace AnBertoCars.Data
{
    public class Contexto : DbContext
    {
        // CLASSES - ENTIDADES - TABELAS
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Telefone> Telefone { get; set; }
        public DbSet<FotoPerfil> FotoPerfil { get; set; }
        public DbSet<Grupos> Grupos { get; set; }
        public DbSet<PublicarAnuncio> PublicarAnuncio { get; set; }
        public DbSet<EspecificacoesVeiculo> EspecificacoesVeiculo { get; set; }
        public DbSet<AvaliarVendedor> AvaliarVendedor { get; set; }
        public DbSet<DirectVendedor> DirectVendedor { get; set; }
        public DbSet<Favoritos> Favoritos { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=201.62.57.93;database=dbLAB2_2020;user id=visualstudio;password=visualstudio;");
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // DEFINIÇÃO CONFIGURAÇÃO TABELAS
            modelBuilder.ApplyConfiguration(new ClienteConfiguracao());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguracao());
            modelBuilder.ApplyConfiguration(new TelefoneConfiguracao());
            modelBuilder.ApplyConfiguration(new FotoPerfilConfiguracao());
            modelBuilder.ApplyConfiguration(new GruposConfiguracao());
            modelBuilder.ApplyConfiguration(new PublicarAnuncioConfiguracao());
            modelBuilder.ApplyConfiguration(new EspecificacoesVeiculoConfiguracao());
            modelBuilder.ApplyConfiguration(new AvaliarVendedorConfiguracao());
            modelBuilder.ApplyConfiguration(new DirectVendedorConfiguracao());
            modelBuilder.ApplyConfiguration(new FavoritosConfiguracao());
        }

        
        
    }
}
