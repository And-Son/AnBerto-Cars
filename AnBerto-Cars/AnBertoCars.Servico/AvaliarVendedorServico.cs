using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class AvaliarVendedorServico
    {
        private readonly AvaliarVendedorRepositorio _avaliarvendedorRepositorio;

        public AvaliarVendedorServico()
        {
            _avaliarvendedorRepositorio = new AvaliarVendedorRepositorio();
        }

        public NotificationResult Salvar(AvaliarVendedor entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {

                    if (entidade.idAvaliacao == 0)
                        _avaliarvendedorRepositorio.Adicionar(entidade);
                    else
                        _avaliarvendedorRepositorio.Atualizar(entidade);

                    notificationResult.Add("Avaliacao cadastrada com sucesso.");
                }

                notificationResult.Result = entidade;

                return notificationResult;
            }
            catch (Exception ex)
            {
                return notificationResult.Add(new NotificationError(ex.Message));
            }
        }

        public IEnumerable<AvaliarVendedor> ListarAtivos()
        {
            return _avaliarvendedorRepositorio.ListarAtivos();
        }

        public void Excluir(AvaliarVendedor entidade)
        {
            _avaliarvendedorRepositorio.Remover(entidade);
        }

        public IEnumerable<AvaliarVendedor> ListarTodos()
        {
            return _avaliarvendedorRepositorio.ListarTodos();
        }
    }
}
