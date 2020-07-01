using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class GruposRepositorio : RepositorioBase<Grupos> , IGruposRepositorio
    {
        public IEnumerable<Grupos> ListarTodos()
        {
            return Contexto
                .Grupos
                .ToList();
        }
    }
}
