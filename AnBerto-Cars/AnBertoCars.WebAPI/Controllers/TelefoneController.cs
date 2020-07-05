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
    public class TelefoneController : ControllerBase
    {
        private readonly ITelefoneServico _telefoneServico;

        public TelefoneController(ITelefoneServico telefoneServico)
        {
            _telefoneServico = telefoneServico;
        }

        [HttpGet("listar")]
        public IEnumerable<Telefone> Listar() => _telefoneServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Telefone entidade)
        {
            return _telefoneServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Telefone entidade)
        {
            return _telefoneServico.Excluir(entidade);
        }
    }
}
