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
    public class GruposController : ControllerBase
    {
        private readonly IGruposServico _gruposServico;

        public GruposController(IGruposServico gruposServico)
        {
            _gruposServico = gruposServico;
        }

        [HttpGet("listar")]
        public IEnumerable<Grupos> Listar() => _gruposServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Grupos entidade)
        {
            return _gruposServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Grupos entidade)
        {
            return _gruposServico.Excluir(entidade);
        }
    }
}
