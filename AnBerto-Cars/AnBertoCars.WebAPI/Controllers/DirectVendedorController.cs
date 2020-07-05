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
    public class DirectVendedorController : ControllerBase
    {
        private readonly IDirectVendedorServico _directvendedorServico;

        public DirectVendedorController(IDirectVendedorServico directVendedorServico)
        {
            _directvendedorServico = directVendedorServico;
        }

        [HttpGet("listar")]
        public IEnumerable<DirectVendedor> Listar() => _directvendedorServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(DirectVendedor entidade)
        {
            return _directvendedorServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(DirectVendedor entidade)
        {
            return _directvendedorServico.Excluir(entidade);
        }
    }
}
