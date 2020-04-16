using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class DirectVendedorRepositorio : RepositorioBase<DirectVendedor>
    {
        public IEnumerable<DirectVendedor> ListarAtivos()
        {
            return Contexto
                .DirectVendedor
                .ToList();
        }
    }
}
