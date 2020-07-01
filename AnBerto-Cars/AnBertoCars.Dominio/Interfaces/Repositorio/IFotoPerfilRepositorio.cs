using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IFotoPerfilRepositorio : IRepositorioBase<FotoPerfil>
    {
        public IEnumerable<FotoPerfil> ListarTodos();
    }
}
