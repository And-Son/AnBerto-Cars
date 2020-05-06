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
                    if (entidade.idFotoPerfil == 0)
                    {
                        _fotoperfilRepositorio.Adicionar(entidade);
                        notificationResult.Add("Foto perfil cadastrado com sucesso.");
                    }
                    else
                    {
                        _fotoperfilRepositorio.Atualizar(entidade);
                        notificationResult.Add("Foto perfil atualizado com sucesso.");
                    }
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        

        public string Excluir(FotoPerfil entidade)
        {
            _fotoperfilRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<FotoPerfil> ListarTodos()
        {
            return _fotoperfilRepositorio.ListarTodos();
        }
    }
}

