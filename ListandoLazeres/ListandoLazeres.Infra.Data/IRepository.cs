using ListandoLazeres.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoLazeres.Infra.Data
{
    public interface IRepository<T> where T : EntidadeBase
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task Add(T entity);
        Task Update(T entity,int id);
        Task Delete(int id);
    }
}
