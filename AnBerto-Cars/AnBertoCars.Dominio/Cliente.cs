using System;
using AnBertoCars.Comum;

namespace AnBertoCars.Dominio
{
    public class Cliente
    {
        public int idCliente { get; set; }
        public int idPerfil { get; set; }
        public string Nome { get; set; }
        public DateTime Idade { get; set; }
        public string CPF { get; set; }
        public int idTelefone { get; set; }
        public int idEndereco { get; set; }
    }
}
