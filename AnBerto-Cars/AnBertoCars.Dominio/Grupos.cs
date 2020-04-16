using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Comum;

namespace AnBertoCars.Dominio
{
    public class Grupos
    {
        public int idGrupo { get; set; }
        public int idCliente { get; set; }
        public int idPerfil { get; set; }
        public int QuantidadeMaxima { get; set; }        
        public string Mensagens { get; set; }    
        
        
            
    }
}
