using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public interface IEnderecoServico
    {
        public NotificationResult Salvar(Endereco entidade);
        public string Excluir(Endereco entidade);
        public IEnumerable<Endereco> ListarTodos();
    }
}
