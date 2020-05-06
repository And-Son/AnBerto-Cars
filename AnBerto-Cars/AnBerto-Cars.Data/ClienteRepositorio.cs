using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class ClienteRepositorio : RepositorioBase<Cliente>
    {
        public IEnumerable<Cliente> ListarTodos()
        {
            return Contexto
                .Cliente
                .ToList();
        }
                
    }
}
