using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class FotoPerfilRepositorio : RepositorioBase<FotoPerfil>
    {
        public IEnumerable<FotoPerfil> ListarAtivos()
        {
            return Contexto
                .FotoPerfil
                .ToList();
        }
    }
}
