using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Dominio;
using AnBertoCars.Servico;
using AnBertoCars.Dominio.Interfaces.Servico;
using Microsoft.AspNetCore.Authorization;

namespace AnBertoCars.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EspecificacoesVeiculoController : ControllerBase
    {
        private readonly IEspecificacoesVeiculoServico _especificacoesVeiculoServico;

        public EspecificacoesVeiculoController(IEspecificacoesVeiculoServico especificacoesVeiculoServico)
        {
            _especificacoesVeiculoServico = especificacoesVeiculoServico;
        }

        [HttpGet("listar")]
        public IEnumerable<EspecificacoesVeiculo> Listar() => _especificacoesVeiculoServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(EspecificacoesVeiculo entidade)
        {
            return _especificacoesVeiculoServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(EspecificacoesVeiculo entidade)
        {
            return _especificacoesVeiculoServico.Excluir(entidade);
        }
    }
}
