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
    public class FotoPerfilController : ControllerBase
    {
        private readonly FotoPerfilServico fotoperfilServico;

        public FotoPerfilController()
        {
            fotoperfilServico = new FotoPerfilServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<FotoPerfil> Ativos() => fotoperfilServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(FotoPerfil entidade)
        {
            return fotoperfilServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(FotoPerfil entidade)
        {
            return fotoperfilServico.Excluir(entidade);
        }
    }
}
