using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Comum;

namespace AnBertoCars.Dominio
{
    public class EspecificacoesVeiculo
    {
        public int idPublicacao { get; set; }
        public int idCliente { get; set; }
        public int idPerfil { get; set; }
        public string Modelo { get; set; }
        public string NomeVeiculo { get; set; }
        public bool Multa { get; set; }
    }
}
