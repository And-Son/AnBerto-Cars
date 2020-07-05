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
    public class FotoPerfilController : ControllerBase
    {
        private readonly IFotoPerfilServico _fotoperfilServico;

        public FotoPerfilController(IFotoPerfilServico fotoPerfilServico)
        {
            _fotoperfilServico = fotoPerfilServico;
        }

        [HttpGet("listar")]
        public IEnumerable<FotoPerfil> Listar() => _fotoperfilServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(FotoPerfil entidade)
        {
            return _fotoperfilServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(FotoPerfil entidade)
        {
            return _fotoperfilServico.Excluir(entidade);
        }
    }
}
