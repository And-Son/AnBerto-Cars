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
    public class PublicarAnuncioController : ControllerBase
    {
        private readonly PublicarAnuncioServico publicarAnuncioServico;

        public PublicarAnuncioController()
        {
            publicarAnuncioServico = new PublicarAnuncioServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<PublicarAnuncio> Ativos() => publicarAnuncioServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(PublicarAnuncio entidade)
        {
            return publicarAnuncioServico.Salvar(entidade);
        }

        [HttpDelete]
        public void Excluir(PublicarAnuncio entidade)
        {
            publicarAnuncioServico.Excluir(entidade);
        }
    }
}
