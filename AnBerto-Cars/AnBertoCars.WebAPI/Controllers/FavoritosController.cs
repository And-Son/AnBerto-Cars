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
    public class FavoritosController : ControllerBase
    {
        private readonly FavoritosServico favoritosServico;

        public FavoritosController()
        {
            favoritosServico = new FavoritosServico();
        }

        [HttpGet("ativos")]
        public IEnumerable<Favoritos> Ativos() => favoritosServico.ListarAtivos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Favoritos entidade)
        {
            return favoritosServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Favoritos entidade)
        {
            return favoritosServico.Excluir(entidade);
        }
    }
}
