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
    public class DirectVendedorController : ControllerBase
    {
        private readonly DirectVendedorServico directvendedorServico;

        public DirectVendedorController()
        {
            directvendedorServico = new DirectVendedorServico();
        }

        [HttpGet("listar")]
        public IEnumerable<DirectVendedor> Listar() => directvendedorServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(DirectVendedor entidade)
        {
            return directvendedorServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(DirectVendedor entidade)
        {
            return directvendedorServico.Excluir(entidade);
        }
    }
}
