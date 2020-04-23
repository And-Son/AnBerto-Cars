using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Dominio;
using AnBertoCars.Servico;

namespace AnBertoCars.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private readonly GruposServico gruposServico;

        public GruposController()
        {
            gruposServico = new GruposServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Grupos> Ativos() => gruposServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Grupos entidade)
        {
            return gruposServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Grupos entidade)
        {
            return gruposServico.Excluir(entidade);
        }
    }
}
