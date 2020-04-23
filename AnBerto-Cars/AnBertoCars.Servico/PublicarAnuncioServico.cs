using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class PublicarAnuncioServico
    {
        private readonly PublicarAnuncioRepositorio _publicarAnuncioRepositorio;

        public PublicarAnuncioServico()
        {
            _publicarAnuncioRepositorio = new PublicarAnuncioRepositorio();
        }

        public NotificationResult Salvar(PublicarAnuncio entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    //if (entidade.idTelefone == 0)
                    _publicarAnuncioRepositorio.Adicionar(entidade);
                    //else
                    //  _telefoneRepositorio.Atualizar(entidade);

                    notificationResult.Add("PublicarAnuncio cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<PublicarAnuncio> ListarAtivos()
        {
            return _publicarAnuncioRepositorio.ListarAtivos();
        }

        public void Excluir(PublicarAnuncio entidade)
        {
            _publicarAnuncioRepositorio.Remover(entidade);
        }

        public IEnumerable<PublicarAnuncio> ListarTodos()
        {
            return _publicarAnuncioRepositorio.ListarTodos();
        }
    }
}
