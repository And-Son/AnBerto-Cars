using System;
using System.Collections.Generic;
using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace AnBertoCars.Data
{
    public class TelefoneRepositorio : RepositorioBase<Telefone>
    {
        public IEnumerable<Telefone> ListarAtivos()
        {
            return Contexto
                .Telefone
                .ToList();
        }
    }
}
