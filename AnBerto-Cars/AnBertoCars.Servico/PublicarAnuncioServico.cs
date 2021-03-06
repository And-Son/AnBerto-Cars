﻿using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Data;
using AnBertoCars.Dominio;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Dominio.Interfaces.Repositorio;
using AnBertoCars.Dominio.Interfaces.Servico;

namespace AnBertoCars.Servico
{
    public class PublicarAnuncioServico : IPublicarAnuncioServico
    {
        private readonly IPublicarAnuncioRepositorio _publicarAnuncioRepositorio;

        public PublicarAnuncioServico(IPublicarAnuncioRepositorio publicarAnuncioRepositorio)
        {
            _publicarAnuncioRepositorio = publicarAnuncioRepositorio;
        }

        public NotificationResult Salvar(PublicarAnuncio entidade)
        {
            var notificationResult = new NotificationResult();

            try
            {
                if (notificationResult.IsValid)
                {
                    if (entidade.idPublicacao == 0)
                    {
                        _publicarAnuncioRepositorio.Adicionar(entidade);
                        notificationResult.Add("Anuncio cadastrado com sucesso.");
                    }
                    else
                    {
                        _publicarAnuncioRepositorio.Atualizar(entidade);
                        notificationResult.Add("Anuncio atualizado com sucesso.");
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

        public NotificationResult Atualizar(PublicarAnuncio entidade)
        {
            var NotificationResult = new NotificationResult();

            try
            {
                if (entidade.idPublicacao != 0)

                    entidade.idPublicacao = entidade.idPublicacao;

                if (NotificationResult.IsValid)
                {
                    _publicarAnuncioRepositorio.Atualizar(entidade);
                    NotificationResult.Add("Usuario Alterado com Sucesso!");

                    return NotificationResult;
                }

                else
                {
                    return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));

                }
            }
            catch (Exception ex)
            {
                return NotificationResult.Add(new NotificationError("O codigo informado não existe!", NotificationErrorType.USER));
            }

        }

        public string Excluir(PublicarAnuncio entidade)
        {
            _publicarAnuncioRepositorio.Remover(entidade);
            return "Excluido";
        }

        public IEnumerable<PublicarAnuncio> ListarTodos()
        {
            return _publicarAnuncioRepositorio.ListarTodos();
        }

        public PublicarAnuncio ListarById(int keys)
        {
            return _publicarAnuncioRepositorio.BuscarUm(keys);
        }
    }
}
