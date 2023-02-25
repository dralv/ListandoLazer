using ListandoLazeres.Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListandoLazeres.Infra.Data.Repositories
{
    public class CategoriaRepository : IRepository<Categoria>
    {
        public Task Add(Categoria entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Categoria>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Categoria> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Categoria entity)
        {
            throw new NotImplementedException();
        }
    }
}
