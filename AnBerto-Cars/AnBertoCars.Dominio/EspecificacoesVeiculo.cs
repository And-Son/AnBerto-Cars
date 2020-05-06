using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Comum;

namespace AnBertoCars.Dominio
{
    public class EspecificacoesVeiculo
    {
        public int idEspecificacoesVeiculo { get; set; }
        public int idPublicacao { get; set; }
        public int idCliente { get; set; }
        public string Modelo { get; set; }
        public string NomeVeiculo { get; set; }
        public bool Multa { get; set; }
    }
}
