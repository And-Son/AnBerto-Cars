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
    public class FavoritosServico : IFavoritosServico
    {
        private readonly IFavoritosRepositorio _favoritosSRepositorio;

        public FavoritosServico(IFavoritosRepositorio favoritosServico)
        {
            _favoritosSRepositorio = favoritosServico;
        }

        public NotificationResult Salvar(Favoritos entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    if (entidade.idSalvos == 0)
                    {
                        _favoritosSRepositorio.Adicionar(entidade);
                        notificationResult.Add("Favorito cadastrado com sucesso.");
                    }
                    else
                    {
                        _favoritosSRepositorio.Atualizar(entidade);
                        notificationResult.Add("Favorito atualizado com sucesso.");
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

        

        public string Excluir(Favoritos entidade)
        {
            _favoritosSRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<Favoritos> ListarTodos()
        {
            return _favoritosSRepositorio.ListarTodos();
        }
    }
}
