using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class EspecificacoesVeiculoServico
    {
        private readonly EspecificacoesVeiculoRepositorio _especificacoesveiculoRepositorio;

        public EspecificacoesVeiculoServico()
        {
            _especificacoesveiculoRepositorio = new EspecificacoesVeiculoRepositorio();
        }

        public NotificationResult Salvar(EspecificacoesVeiculo entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    //if (entidade.idTelefone == 0)
                    _especificacoesveiculoRepositorio.Adicionar(entidade);
                    //else
                    //  _telefoneRepositorio.Atualizar(entidade);

                    notificationResult.Add("Especificacoes cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<EspecificacoesVeiculo> ListarAtivos()
        {
            return _especificacoesveiculoRepositorio.ListarAtivos();
        }

        public void Excluir(EspecificacoesVeiculo entidade)
        {
            _especificacoesveiculoRepositorio.Remover(entidade);
        }

        public IEnumerable<EspecificacoesVeiculo> ListarTodos()
        {
            return _especificacoesveiculoRepositorio.ListarTodos();
        }
    }
}
