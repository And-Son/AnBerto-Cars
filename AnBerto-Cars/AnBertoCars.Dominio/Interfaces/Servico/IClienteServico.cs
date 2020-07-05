using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IClienteServico
    {
        public NotificationResult Salvar(Cliente entidade);
        public Cliente ListarById(int keys);
        public string Excluir(Cliente entidade);
        public IEnumerable<Cliente> ListarTodos();
        Task<Cliente> Authenticate(string login, string senha);
    }
}

