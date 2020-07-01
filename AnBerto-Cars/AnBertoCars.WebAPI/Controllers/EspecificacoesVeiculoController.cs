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

namespace AnBertoCars.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EspecificacoesVeiculoController : ControllerBase
    {
        private readonly IEspecificacoesVeiculoServico especificacoesVeiculoServico;

        public EspecificacoesVeiculoController(IEspecificacoesVeiculoServico especificacoesVeiculoServico)
        {
            especificacoesVeiculoServico = especificacoesVeiculoServico;
        }

        [HttpGet("listar")]
        public IEnumerable<EspecificacoesVeiculo> Listar() => especificacoesVeiculoServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(EspecificacoesVeiculo entidade)
        {
            return especificacoesVeiculoServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(EspecificacoesVeiculo entidade)
        {
            return especificacoesVeiculoServico.Excluir(entidade);
        }
    }
}
