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
    public class ClienteController : ControllerBase
    {
        private readonly ClienteServico clienteServico;

        public ClienteController()
        {
            clienteServico = new ClienteServico();
        }

        [HttpGet("listar")]
        public IEnumerable<Cliente> Listar() => clienteServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Cliente entidade)
        {
            return clienteServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Cliente entidade)
        {
            return clienteServico.Excluir(entidade);
        }
    }
}