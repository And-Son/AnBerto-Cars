using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class GruposServico
    {
        private readonly GruposRepositorio _gruposRepositorio;

        public GruposServico()
        {
            _gruposRepositorio = new GruposRepositorio();
        }

        public NotificationResult Salvar(Grupos entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    //if (entidade.idTelefone == 0)
                    _gruposRepositorio.Adicionar(entidade);
                    //else
                    //  _telefoneRepositorio.Atualizar(entidade);

                    notificationResult.Add("Grupos cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<Grupos> ListarAtivos()
        {
            return _gruposRepositorio.ListarAtivos();
        }

        public void Excluir(Grupos entidade)
        {
            _gruposRepositorio.Remover(entidade);
        }

        public IEnumerable<Grupos> ListarTodos()
        {
            return _gruposRepositorio.ListarTodos();
        }
    }
}
