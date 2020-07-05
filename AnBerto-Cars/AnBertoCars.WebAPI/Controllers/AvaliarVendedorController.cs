using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Dominio;
using AnBertoCars.Dominio.Interfaces.Servico;
using AnBertoCars.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace AnBertoCars.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AvaliarVendedorController : ControllerBase
    {
        private readonly IAvaliarVendedorServico _avaliarvendedorServico;

        public AvaliarVendedorController(IAvaliarVendedorServico produtoServico)
        {
            _avaliarvendedorServico = produtoServico;
        }

        [HttpGet("listar")]
        public IEnumerable<AvaliarVendedor> Listar() => _avaliarvendedorServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(AvaliarVendedor entidade)
        {
            return _avaliarvendedorServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(AvaliarVendedor entidade)
        {
            return _avaliarvendedorServico.Excluir(entidade);            
        }
    }
}