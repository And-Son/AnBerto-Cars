using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IGruposRepositorio : IRepositorioBase<Grupos>
    {
        public IEnumerable<Grupos> ListarTodos();
    }
}
