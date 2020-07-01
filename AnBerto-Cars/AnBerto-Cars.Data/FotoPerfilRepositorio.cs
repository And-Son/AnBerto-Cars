using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class FotoPerfilRepositorio : RepositorioBase<FotoPerfil> , IFotoPerfilRepositorio
    {
        public IEnumerable<FotoPerfil> ListarTodos()
        {
            return Contexto
                .FotoPerfil
                .ToList();
        }
    }
}
