using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Dominio.Interfaces.Servico;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Servico
{
    public class EnderecoServico : IEnderecoServico
    {
        private readonly IEnderecoRepositorio _enderecoRepositorio;

        public EnderecoServico(IEnderecoRepositorio enderecoRepositorio)
        {
            _enderecoRepositorio = enderecoRepositorio;
        }

        public NotificationResult Salvar(Endereco entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    if (entidade.idEndereco == 0)
                    {
                        _enderecoRepositorio.Adicionar(entidade);
                        notificationResult.Add("Endereco cadastrado com sucesso.");
                    }
                    else
                    {
                        _enderecoRepositorio.Atualizar(entidade);
                        notificationResult.Add("Endereco atualizado com sucesso.");
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
