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
    public class GruposServico : IGruposServico
    {
        private readonly IGruposRepositorio _gruposRepositorio;

        public GruposServico(IGruposRepositorio gruposRepositorio)
        {
            _gruposRepositorio = gruposRepositorio;
        }

        public NotificationResult Salvar(Grupos entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    if (entidade.idGrupo == 0)
                    {
                        _gruposRepositorio.Adicionar(entidade);
                        notificationResult.Add("Grupo cadastrado com sucesso.");
                    }
                    else
                    {
                        _gruposRepositorio.Atualizar(entidade);
                        notificationResult.Add("Grupo atualizado com sucesso.");
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

        

        public string Excluir(Grupos entidade)
        {
            _gruposRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<Grupos> ListarTodos()
        {
            return _gruposRepositorio.ListarTodos();
        }
    }
}
