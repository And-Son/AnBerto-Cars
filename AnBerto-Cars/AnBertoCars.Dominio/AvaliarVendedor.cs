using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Comum;

namespace AnBertoCars.Dominio
{
    public class AvaliarVendedor
    {
        public int idAvaliacao { get; set; }
        public int idCliente { get; set; }
        public int idPerfil { get; set; }
        public int idPublicacao { get; set; }
        public int Nota { get; set; }
        public string Comentario { get; set; }        

        //public Cliente Cliente { get; set; }

        //public PublicarAnuncio PublicarAnuncio { get; set; }


    }
}
