using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AnBertoCars.Comum.NotificationPattern;
using AnBertoCars.Dominio;
using AnBertoCars.Servico;
using Microsoft.AspNetCore.Cors;
using AnBertoCars.Dominio.Interfaces.Servico;

namespace AnBertoCars.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[EnableCors(origins: "http://localhost:8100/", headers: "*", methods: "*")]
    public class PublicarAnuncioController : ControllerBase
    {
        private readonly IPublicarAnuncioServico publicarAnuncioServico;

        public PublicarAnuncioController(IPublicarAnuncioServico publicarAnuncioServico)
        {
            publicarAnuncioServico = publicarAnuncioServico;
        }

        [HttpGet("listar")]
        [EnableCors]
        public IEnumerable<PublicarAnuncio> Listar() => publicarAnuncioServico.ListarTodos();

        [HttpPost("salvar")]
        [EnableCors]
        public NotificationResult Salvar(PublicarAnuncio entidade)
        {
            return publicarAnuncioServico.Salvar(entidade);
        }

        [HttpGet("listarum")]
        [EnableCors]
        public PublicarAnuncio ListarById(int keys)
        {
            return publicarAnuncioServico.ListarById(keys);
        }

        [HttpDelete]
        public string Excluir(PublicarAnuncio entidade)
        {
            return publicarAnuncioServico.Excluir(entidade);
        }
    }
}
