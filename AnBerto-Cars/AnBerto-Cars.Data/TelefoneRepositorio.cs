using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class TelefoneRepositorio : RepositorioBase<Telefone> , ITelefoneRepositorio
    {
        public IEnumerable<Telefone> ListarTodos()
        {
            return Contexto
                .Telefone
                .ToList();
        }
    }
}
