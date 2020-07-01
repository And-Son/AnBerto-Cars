using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class DirectVendedorRepositorio : RepositorioBase<DirectVendedor> , IDirectVendedorRepositorio
    {
        public IEnumerable<DirectVendedor> ListarTodos()
        {
            return Contexto
                .DirectVendedor
                .ToList();
        }
    }
}
