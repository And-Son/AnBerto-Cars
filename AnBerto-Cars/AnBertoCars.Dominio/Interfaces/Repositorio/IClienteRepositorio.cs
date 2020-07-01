using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IClienteRepositorio : IRepositorioBase<Cliente>
    {
        public IEnumerable<Cliente> ListarTodos();
    }
}
