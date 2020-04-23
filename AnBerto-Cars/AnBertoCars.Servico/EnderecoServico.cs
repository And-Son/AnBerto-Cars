using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class EnderecoServico
    {
        private readonly EnderecoRepositorio _enderecoRepositorio;

        public EnderecoServico()
        {
            _enderecoRepositorio = new EnderecoRepositorio();
        }

        public NotificationResult Salvar(Endereco entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    //if (entidade.idTelefone == 0)
                    _enderecoRepositorio.Adicionar(entidade);
                    //else
                    //  _telefoneRepositorio.Atualizar(entidade);

                    notificationResult.Add("Endereco cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Endereco> ListarAtivos()
        {
            return _enderecoRepositorio.ListarAtivos();
        }

        public string Excluir(Endereco entidade)
        {
            _enderecoRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<Endereco> ListarTodos()
        {
            return _enderecoRepositorio.ListarTodos();
        }
    }
}
