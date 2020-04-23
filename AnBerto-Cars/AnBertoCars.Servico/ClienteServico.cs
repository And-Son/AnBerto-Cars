using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Comum.Util;

namespace AnBertoCars.Servico
{
    public class ClienteServico
    {
        private readonly ClienteRepositorio _clienteRepositorio;
        //private readonly ValidaCPF _validaCPF;

        public ClienteServico()
        {
            _clienteRepositorio = new ClienteRepositorio();
            //_validaCPF = new ValidaCPF();
        }

        public NotificationResult Salvar(Cliente entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    //if (entidade.idTelefone == 0)
                    _clienteRepositorio.Adicionar(entidade);
                    //else
                    //  _telefoneRepositorio.Atualizar(entidade);

                    notificationResult.Add("Cliente cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Cliente> ListarAtivos()
        {
            return _clienteRepositorio.ListarAtivos();
        }

        public string Excluir(Cliente entidade)
        {
            _clienteRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<Cliente> ListarTodos()
        {
            return _clienteRepositorio.ListarTodos();
        }
    }
}
