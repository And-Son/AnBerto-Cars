using AnBertoCars.Comum.NotificationPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Servico
{
    public  interface IFotoPerfilServico
    {
        public NotificationResult Salvar(FotoPerfil entidade);
        public string Excluir(FotoPerfil entidade);
        public IEnumerable<FotoPerfil> ListarTodos();
    }
}
