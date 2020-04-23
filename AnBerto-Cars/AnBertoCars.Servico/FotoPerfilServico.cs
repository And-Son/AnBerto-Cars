using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class FotoPerfilServico
    {
        private readonly FotoPerfilRepositorio _fotoperfilRepositorio;

        public FotoPerfilServico()
        {
            _fotoperfilRepositorio = new FotoPerfilRepositorio();
        }

        public NotificationResult Salvar(FotoPerfil entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    //if (entidade.idTelefone == 0)
                    _fotoperfilRepositorio.Adicionar(entidade);
                    //else
                    //  _telefoneRepositorio.Atualizar(entidade);

                    notificationResult.Add("Endereco cadastrado com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<FotoPerfil> ListarAtivos()
        {
            return _fotoperfilRepositorio.ListarAtivos();
        }

        public void Excluir(FotoPerfil entidade)
        {
            _fotoperfilRepositorio.Remover(entidade);
        }

        public IEnumerable<FotoPerfil> ListarTodos()
        {
            return _fotoperfilRepositorio.ListarTodos();
        }
    }
}

