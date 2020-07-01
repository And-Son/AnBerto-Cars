using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Dominio.Interfaces.Servico;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Servico
{
    public class FotoPerfilServico : IFotoPerfilServico
    {
        private readonly IFotoPerfilRepositorio _fotoperfilRepositorio;

        public FotoPerfilServico(IFotoPerfilRepositorio fotoPerfilRepositorio)
        {
            _fotoperfilRepositorio = fotoPerfilRepositorio;
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

