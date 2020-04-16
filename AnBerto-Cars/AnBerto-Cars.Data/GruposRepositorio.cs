using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class GruposRepositorio : RepositorioBase<Grupos>
    {
        public IEnumerable<Grupos> ListarAtivos()
        {
            return Contexto
                .Grupos
                .ToList();
        }
    }
}
