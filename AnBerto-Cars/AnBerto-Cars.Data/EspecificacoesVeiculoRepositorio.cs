using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class EspecificacoesVeiculoRepositorio : RepositorioBase<EspecificacoesVeiculo>
    {
        public IEnumerable<EspecificacoesVeiculo> ListarTodos()
        {
            return Contexto
                .EspecificacoesVeiculo
                .ToList();
        }
    }
}
