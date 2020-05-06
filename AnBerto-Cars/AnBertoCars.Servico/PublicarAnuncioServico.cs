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
                    if (entidade.idPublicacao == 0)
                    {
                        _publicarAnuncioRepositorio.Adicionar(entidade);
                        notificationResult.Add("Anuncio cadastrado com sucesso.");
                    }
                    else
                    {
                        _publicarAnuncioRepositorio.Atualizar(entidade);
                        notificationResult.Add("Anuncio atualizado com sucesso.");
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

        

        public string Excluir(PublicarAnuncio entidade)
        {
            _publicarAnuncioRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<PublicarAnuncio> ListarTodos()
        {
            return _publicarAnuncioRepositorio.ListarTodos();
        }
    }
}
