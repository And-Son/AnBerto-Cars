using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IFavoritosRepositorio : IRepositorioBase<Favoritos>
    {
        public IEnumerable<Favoritos> ListarTodos();
    }
}
