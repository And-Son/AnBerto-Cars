using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class TelefoneServico
    {
        private readonly TelefoneRepositorio _telefoneRepositorio;

        public TelefoneServico()
        {
            _telefoneRepositorio = new TelefoneRepositorio();
        }

        public NotificationResult Salvar(Telefone entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    if (entidade.idTelefone == 0)
                        _telefoneRepositorio.Adicionar(entidade);
                    else
                        _telefoneRepositorio.Atualizar(entidade);

                    notificationResult.Add("Telefone cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Telefone> ListarAtivos()
        {
            return _telefoneRepositorio.ListarAtivos();
        }

        public void Excluir(Telefone entidade)
        {
            _telefoneRepositorio.Remover(entidade);
        }

        public IEnumerable<Telefone> ListarTodos()
        {
            return _telefoneRepositorio.ListarTodos();
        }
    }
}
