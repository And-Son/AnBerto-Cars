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
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Authorization;

namespace AnBertoCars.WebAPI.Controllers
{
    [Authorize]
    [Route("[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteServico _clienteServico;

        public ClienteController(IClienteServico clienteServico)
        {
            _clienteServico = clienteServico;
        }

        [HttpGet("listar")]
        public IEnumerable<Cliente> Listar() => _clienteServico.ListarTodos();

        [HttpGet("listarum")]
        [EnableCors]
        public Cliente ListarById(int keys)
        {
            return _clienteServico.ListarById(keys);
        }

        [AllowAnonymous]
        [HttpPost("authenticate")]
        [EnableCors]
        public async Task<IActionResult> Authenticate([FromBody]Cliente userParam)
        {
            var usuario = await _clienteServico.Authenticate(userParam.UsuarioLogin, userParam.SenhaLogin);

            if (usuario == null)
                return BadRequest(new { message = "Usuário ou senha incorreto" });

            return Ok(usuario);
        }

        [HttpPost("salvar")]
        public NotificationResult Salvar(Cliente entidade)
        {
            return _clienteServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Cliente entidade)
        {
            return _clienteServico.Excluir(entidade);
        }
    }
}