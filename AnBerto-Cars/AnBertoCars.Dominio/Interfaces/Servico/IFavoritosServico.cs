using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IFavoritosServico
    {
        public NotificationResult Salvar(Favoritos entidade);
        public string Excluir(Favoritos entidade);
        public IEnumerable<Favoritos> ListarTodos();
    }
}
