using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class PublicarAnuncioRepositorio : RepositorioBase<PublicarAnuncio>
    {
        public IEnumerable<PublicarAnuncio> ListarTodos()
        {
            return Contexto
                .PublicarAnuncio
                .ToList();
        }
    }
}
