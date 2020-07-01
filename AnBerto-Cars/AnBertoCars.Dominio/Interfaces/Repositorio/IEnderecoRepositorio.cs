using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IEnderecoRepositorio : IRepositorioBase<Endereco>
    {
        public IEnumerable<Endereco> ListarTodos();
    }
}
