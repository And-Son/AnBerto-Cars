using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class FavoritosServico
    {
        private readonly FavoritosRepositorio _favoritosSRepositorio;

        public FavoritosServico()
        {
            _favoritosSRepositorio = new FavoritosRepositorio();
        }

        public NotificationResult Salvar(Favoritos entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    //if (entidade.idTelefone == 0)
                    _telefoneRepositorio.Adicionar(entidade);
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

        public IEnumerable<Favoritos> ListarAtivos()
        {
            return _favoritosSRepositorio.ListarAtivos();
        }

        public void Excluir(Favoritos entidade)
        {
            _favoritosSRepositorio.Remover(entidade);
        }

        public IEnumerable<Favoritos> ListarTodos()
        {
            return _favoritosSRepositorio.ListarTodos();
        }
    }
}
