using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;

namespace AnBertoCars.Servico
{
    public class DirectVendedorServico
    {
        private readonly DirectVendedorRepositorio _directvendedorRepositorio;

        public DirectVendedorServico()
        {
            _directvendedorRepositorio = new DirectVendedorRepositorio();
        }

        public NotificationResult Salvar(DirectVendedor entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    if (entidade.idDirectVendedor == 0)
                    {
                        _directvendedorRepositorio.Adicionar(entidade);
                        notificationResult.Add("Direct cadastrada com sucesso.");
                    }
                    else
                    {
                        _directvendedorRepositorio.Atualizar(entidade);
                        notificationResult.Add("Direct atualizada com sucesso.");
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

        

        public string Excluir(DirectVendedor entidade)
        {
            _directvendedorRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<DirectVendedor> ListarTodos()
        {
            return _directvendedorRepositorio.ListarTodos();
        }
    }
}
