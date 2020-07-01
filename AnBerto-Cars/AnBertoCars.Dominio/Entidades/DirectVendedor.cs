using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Comum;

namespace AnBertoCars.Dominio
{
    public class DirectVendedor
    {
        public int idDirectVendedor { get; set; }
        public int idPublicacao { get; set; }
        public int idCliente { get; set; }
        public string Mensagem { get; set; }
    }
}
