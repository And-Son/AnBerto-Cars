using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Dominio;
using AnBertoCars.Servico;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AnBertoCars.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AvaliarVendedorController : ControllerBase
    {
        private readonly AvaliarVendedorServico avaliarvendedorServico;

        public AvaliarVendedorController()
        {
            avaliarvendedorServico = new AvaliarVendedorServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<AvaliarVendedor> Ativos() => avaliarvendedorServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(AvaliarVendedor entidade)
        {
            return avaliarvendedorServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(AvaliarVendedor entidade)
        {
            return avaliarvendedorServico.Excluir(entidade);            
        }
    }
}