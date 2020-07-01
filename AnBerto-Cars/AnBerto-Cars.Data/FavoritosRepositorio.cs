using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class FavoritosRepositorio : RepositorioBase<Favoritos> , IFavoritosRepositorio
    {
        public IEnumerable<Favoritos> ListarTodos()
        {
            return Contexto
                .Favoritos
                .ToList();
        }
    }
}
