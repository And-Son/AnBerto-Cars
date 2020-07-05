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
using Microsoft.AspNetCore.Authorization;

namespace AnBertoCars.WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    //[EnableCors(origins: "http://localhost:8100/", headers: "*", methods: "*")]
    public class PublicarAnuncioController : ControllerBase
    {
        private readonly IPublicarAnuncioServico _publicarAnuncioServico;

        public PublicarAnuncioController(IPublicarAnuncioServico publicarAnuncioServico)
        {
            _publicarAnuncioServico = publicarAnuncioServico;
        }

        [HttpGet("listar")]
        [EnableCors]
        public IEnumerable<PublicarAnuncio> Listar() => _publicarAnuncioServico.ListarTodos();

        [HttpPost("salvar")]
        [EnableCors]
        public NotificationResult Salvar(PublicarAnuncio entidade)
        {
            return _publicarAnuncioServico.Salvar(entidade);
        }

        [HttpPut("atualizar")]
        [EnableCors]
        public NotificationResult Atualizar(PublicarAnuncio entidade)
        {
            return _publicarAnuncioServico.Atualizar(entidade);
        }

        [HttpGet("listarum")]
        [EnableCors]
        public PublicarAnuncio ListarById(int keys)
        {
            return _publicarAnuncioServico.ListarById(keys);
        }

        [HttpDelete("excluir")]
        [EnableCors]
        public string Excluir(PublicarAnuncio entidade)
        {
            return _publicarAnuncioServico.Excluir(entidade);
        }
    }
}
