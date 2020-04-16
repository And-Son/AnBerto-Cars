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
    public class TelefoneController : ControllerBase
    {
        private readonly TelefoneServico telefoneServico;

        public TelefoneController()
        {
            telefoneServico = new TelefoneServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Telefone> Ativos() => telefoneServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Telefone entidade)
        {
            return telefoneServico.Salvar(entidade);
        }

        [HttpDelete]
        public void Excluir(Telefone entidade)
        {
            telefoneServico.Excluir(entidade);
        }
    }
}
