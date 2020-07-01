using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface ITelefoneRepositorio : IRepositorioBase<Telefone>
    {
        public IEnumerable<Telefone> ListarTodos();
    }
}
