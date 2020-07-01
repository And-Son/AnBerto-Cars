using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IDirectVendedorRepositorio : IRepositorioBase<DirectVendedor>
    {
        public IEnumerable<DirectVendedor> ListarTodos();
    }
}
