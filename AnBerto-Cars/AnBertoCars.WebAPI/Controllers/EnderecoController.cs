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
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoServico enderecoServico;

        public EnderecoController(IEnderecoServico enderecoServico)
        {
            enderecoServico = enderecoServico;
        }

        [HttpGet("listar")]
        public IEnumerable<Endereco> Listar() => enderecoServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Endereco entidade)
        {
            return enderecoServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Endereco entidade)
        {
            return enderecoServico.Excluir(entidade);
        }
    }
}
