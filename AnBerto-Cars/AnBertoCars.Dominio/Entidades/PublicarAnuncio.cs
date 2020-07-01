using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Comum;

namespace AnBertoCars.Dominio
{
    public class PublicarAnuncio
    {
        public int idPublicacao { get; set; }
        public int idCliente { get; set; } 
        public string ImagemPublic { get; set; }
        public string Texto { get; set; }
        public string Comentar { get; set; }
        public bool Curtir { get; set; }
    }
}
