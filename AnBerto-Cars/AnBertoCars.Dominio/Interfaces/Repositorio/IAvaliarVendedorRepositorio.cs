using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IAvaliarVendedorRepositorio : IRepositorioBase<AvaliarVendedor>
    {
        public IEnumerable<AvaliarVendedor> ListarTodos();
    }
}
