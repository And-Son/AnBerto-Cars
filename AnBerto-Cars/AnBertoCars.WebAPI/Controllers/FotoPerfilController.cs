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
    public class FotoPerfilController : ControllerBase
    {
        private readonly IFotoPerfilServico fotoperfilServico;

        public FotoPerfilController(IFotoPerfilServico fotoPerfilServico)
        {
            fotoperfilServico = fotoPerfilServico;
        }

        [HttpGet("listar")]
        public IEnumerable<FotoPerfil> Listar() => fotoperfilServico.ListarTodos();

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
