using System;
using System.Collections.Generic;
using System.Text;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IPublicarAnuncioRepositorio : IRepositorioBase<PublicarAnuncio>
    {
        public IEnumerable<PublicarAnuncio> ListarTodos();
        public PublicarAnuncio BuscarUm(int idPublicacao);
    }
}
