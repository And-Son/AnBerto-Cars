using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Comum.Util;
using AnBertoCars.Dominio.Interfaces.Servico;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Servico
{
    public class ClienteServico : IClienteServico
    {
        private readonly IClienteRepositorio _clienteRepositorio;
        //private readonly ValidaCPF _validaCPF;

        public ClienteServico(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
            //_validaCPF = new ValidaCPF();
        }

        public NotificationResult Salvar(Cliente entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    if (entidade.idCliente == 0)
                    {
                        _clienteRepositorio.Adicionar(entidade);
                        notificationResult.Add("Cliente cadastrado com sucesso.");
                    }
                    else
                    {
                        _clienteRepositorio.Atualizar(entidade);
                        notificationResult.Add("Cliente atualizado com sucesso.");
                    }
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
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
