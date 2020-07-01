using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface ITelefoneServico
    {
        public NotificationResult Salvar(Telefone entidade);
        public string Excluir(Telefone entidade);
        public IEnumerable<Telefone> ListarTodos();
    }
}
