using System;
using AnBertoCars.Comum;
using AnBertoCars.Comum.Util;

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

        public int CalculaIdade()
        {
            int idade = DateTime.Now.Year - Idade.Year;
            if (DateTime.Now.DayOfYear < Idade.DayOfYear)
            {
                idade = idade - 1;
            }
            return idade;
        }
        
        public bool ValidarCPF()
        {                      
            return ValidaCPF.Validar(CPF);         
        }
    }
}
