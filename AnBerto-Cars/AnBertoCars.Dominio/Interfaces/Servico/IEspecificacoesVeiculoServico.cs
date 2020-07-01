using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IEspecificacoesVeiculoServico
    {
        public NotificationResult Salvar(EspecificacoesVeiculo entidade);
        public string Excluir(EspecificacoesVeiculo entidade);
        public IEnumerable<EspecificacoesVeiculo> ListarTodos();
    }
}
