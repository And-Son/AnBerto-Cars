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
    public class FavoritosController : ControllerBase
    {
        private readonly IFavoritosServico _favoritosServico;

        public FavoritosController(IFavoritosServico favoritosServico)
        {
            _favoritosServico = favoritosServico;
        }

        [HttpGet("listar")]
        public IEnumerable<Favoritos> Listar() => _favoritosServico.ListarTodos();

        [HttpPost("salvar")]
        public NotificationResult Salvar(Favoritos entidade)
        {
            return _favoritosServico.Salvar(entidade);
        }

        [HttpDelete]
        public string Excluir(Favoritos entidade)
        {
            return _favoritosServico.Excluir(entidade);
        }
    }
}
