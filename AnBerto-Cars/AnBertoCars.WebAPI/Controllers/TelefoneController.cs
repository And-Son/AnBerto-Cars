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
    public class TelefoneController : ControllerBase
    {
        private readonly ITelefoneServico telefoneServico;

        public TelefoneController(ITelefoneServico telefoneServico)
        {
            telefoneServico = telefoneServico;
        }

        [HttpGet("listar")]
        public IEnumerable<Telefone> Listar() => telefoneServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Telefone entidade)
        {
            return telefoneServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Telefone entidade)
        {
            return telefoneServico.Excluir(entidade);
        }
    }
}
