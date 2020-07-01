using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class PublicarAnuncioRepositorio : RepositorioBase<PublicarAnuncio> , IPublicarAnuncioRepositorio
    {
        public IEnumerable<PublicarAnuncio> ListarTodos()
        {
            return Contexto
                .PublicarAnuncio
                .ToList();
        }

        public PublicarAnuncio BuscarUm(int idPublicacao)
        {
            return Contexto
                .PublicarAnuncio
                .Find(idPublicacao);
        }
    }
}
