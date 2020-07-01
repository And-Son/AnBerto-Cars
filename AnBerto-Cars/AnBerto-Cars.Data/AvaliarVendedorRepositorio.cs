using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using AnBertoCars.Dominio.Interfaces.Repositorio;

namespace AnBertoCars.Data
{
    public class AvaliarVendedorRepositorio : RepositorioBase<AvaliarVendedor>, IAvaliarVendedorRepositorio
    {
        public IEnumerable<AvaliarVendedor> ListarTodos()
        {
            return Contexto
                .AvaliarVendedor
                //.Include(f => f.Cliente)
                .ToList();
        }
    }
}
