using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IAvaliarVendedorServico
    {
        public NotificationResult Salvar(AvaliarVendedor entidade);

        public IEnumerable<AvaliarVendedor> ListarTodos();

        public string Excluir(AvaliarVendedor entidade);
    }
}
