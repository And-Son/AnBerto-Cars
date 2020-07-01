using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class EspecificacoesVeiculoRepositorio : RepositorioBase<EspecificacoesVeiculo> , IEspecificacoesVeiculoRepositorio
    {
        public IEnumerable<EspecificacoesVeiculo> ListarTodos()
        {
            return Contexto
                .EspecificacoesVeiculo
                .ToList();
        }
    }
}
