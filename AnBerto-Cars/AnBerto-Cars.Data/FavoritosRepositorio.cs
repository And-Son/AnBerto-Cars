using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class FavoritosRepositorio : RepositorioBase<Favoritos>
    {
        public IEnumerable<Favoritos> ListarAtivos()
        {
            return Contexto
                .Favoritos
                .ToList();
        }
    }
}
