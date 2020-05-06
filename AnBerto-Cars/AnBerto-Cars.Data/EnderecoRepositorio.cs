using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class EnderecoRepositorio : RepositorioBase<Endereco>
    {
        public IEnumerable<Endereco> ListarTodos()
        {
            return Contexto
                .Endereco
                .ToList();
        }
    }
}
