﻿using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;

namespace AnBertoCars.Servico
{
    public class EspecificacoesVeiculoServico
    {
        private readonly EspecificacoesVeiculoRepositorio _especificacoesveiculoRepositorio;

        public EspecificacoesVeiculoServico()
        {
            _especificacoesveiculoRepositorio = new EspecificacoesVeiculoRepositorio();
        }

        public NotificationResult Salvar(EspecificacoesVeiculo entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    if (entidade.idEspecificacoesVeiculo == 0)
                    {
                        _especificacoesveiculoRepositorio.Adicionar(entidade);
                        notificationResult.Add("Especificacao cadastrado com sucesso.");
                    }
                    else
                    {
                        _especificacoesveiculoRepositorio.Atualizar(entidade);
                        notificationResult.Add("Especificacao atualizado com sucesso.");
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

        

        public string Excluir(EspecificacoesVeiculo entidade)
        {
            _especificacoesveiculoRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<EspecificacoesVeiculo> ListarTodos()
        {
            return _especificacoesveiculoRepositorio.ListarTodos();
        }
    }
}
