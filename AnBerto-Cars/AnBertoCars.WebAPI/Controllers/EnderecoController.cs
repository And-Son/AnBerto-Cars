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
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoServico _enderecoServico;

        public EnderecoController(IEnderecoServico enderecoServico)
        {
            _enderecoServico = enderecoServico;
        }

        [HttpGet("listar")]
        public IEnumerable<Endereco> Listar() => _enderecoServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Endereco entidade)
        {
            return _enderecoServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Endereco entidade)
        {
            return _enderecoServico.Excluir(entidade);
        }
    }
}
