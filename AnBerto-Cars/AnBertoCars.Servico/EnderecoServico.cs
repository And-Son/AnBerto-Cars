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

                    if (entidade.idEndereco == 0)
                        _enderecoRepositorio.Adicionar(entidade);
                    else
                        _enderecoRepositorio.Atualizar(entidade);

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

        public void Excluir(Endereco entidade)
        {
            _enderecoRepositorio.Remover(entidade);
        }

        public IEnumerable<Endereco> ListarTodos()
        {
            return _enderecoRepositorio.ListarTodos();
        }
    }
}
