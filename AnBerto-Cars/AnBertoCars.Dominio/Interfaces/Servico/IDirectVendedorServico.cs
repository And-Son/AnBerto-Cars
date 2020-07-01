using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IDirectVendedorServico
    {
        public NotificationResult Salvar(DirectVendedor entidade);
        public string Excluir(DirectVendedor entidade);
        public IEnumerable<DirectVendedor> ListarTodos();
    }
}
