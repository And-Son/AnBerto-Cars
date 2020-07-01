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
    public class GruposController : ControllerBase
    {
        private readonly IGruposServico gruposServico;

        public GruposController(IGruposServico gruposServico)
        {
            gruposServico = gruposServico;
        }

        [HttpGet("listar")]
        public IEnumerable<Grupos> Listar() => gruposServico.ListarTodos();

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
