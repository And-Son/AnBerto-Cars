using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IClienteServico
    {
        public NotificationResult Salvar(Cliente entidade);
        public string Excluir(Cliente entidade);
        public IEnumerable<Cliente> ListarTodos();
    }
}

