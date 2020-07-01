using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IPublicarAnuncioServico
    {
        public NotificationResult Salvar(PublicarAnuncio entidade);
        public string Excluir(PublicarAnuncio entidade);
        public IEnumerable<PublicarAnuncio> ListarTodos();
        public PublicarAnuncio ListarById(int keys);
    }
}
