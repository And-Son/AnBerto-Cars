using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Comum;
namespace AnBertoCars.Dominio
{
    public class Endereco
    {
        public int idEndereco { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public string Cidade{ get; set; }
        public int CEP { get; set; }

    }
}
