using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IEspecificacoesVeiculoRepositorio : IRepositorioBase<EspecificacoesVeiculo>
    {
        public IEnumerable<EspecificacoesVeiculo> ListarTodos();
    }
}
