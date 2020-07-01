using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IGruposServico
    {
        public NotificationResult Salvar(Grupos entidade);
        public string Excluir(Grupos entidade);
        public IEnumerable<Grupos> ListarTodos();
    }
}
