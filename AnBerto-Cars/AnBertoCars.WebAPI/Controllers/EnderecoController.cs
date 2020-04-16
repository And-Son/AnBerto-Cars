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
    public class EnderecoController : ControllerBase
    {
        private readonly EnderecoServico enderecoServico;

        public EnderecoController()
        {
            enderecoServico = new EnderecoServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Endereco> Ativos() => enderecoServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Endereco entidade)
        {
            return enderecoServico.Salvar(entidade);
        }

        [HttpDelete]
        public void Excluir(Endereco entidade)
        {
            enderecoServico.Excluir(entidade);
        }
    }
}
