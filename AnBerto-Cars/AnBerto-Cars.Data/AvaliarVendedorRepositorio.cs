using System.Text;
using AnBertoCars.Dominio;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace AnBertoCars.Data
{
    public class AvaliarVendedorRepositorio : RepositorioBase<AvaliarVendedor>
    {
        public IEnumerable<AvaliarVendedor> ListarAtivos()
        {
            return Contexto
                .AvaliarVendedor
                //.Include(f => f.Cliente)
                .ToList();
        }
    }
}
