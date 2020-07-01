using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class EnderecoRepositorio : RepositorioBase<Endereco> , IEnderecoRepositorio
    {
        public IEnumerable<Endereco> ListarTodos()
        {
            return Contexto
                .Endereco
                .ToList();
        }
    }
}
