using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AnBertoCars.Dominio.Interfaces.Repositorio
{
    public interface IRepositorioBase<T> where T : class
    {
        public T ListarUm(params object[] keys);
        public List<T> ListarTodos();
        void Adicionar(T entidade, bool saveChanges = true);
        void Remover(T entidade, bool saveChanges = true);
        void Atualizar(T entidade, bool saveChanges = true);
        public void SaveChanges();
    }
}
