using Dapper;
using ListandoLazeres.Domain.Entidades;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;
using static Dapper.SqlMapper;

namespace ListandoLazeres.Infra.Data.Repositories
{
    public class LazerRepository : IRepository<Lazer>
    {
        private readonly IConfiguration _config;
      
        public LazerRepository(IConfiguration config)
        {

            _config = config;
           
        }
        public async Task Add(Lazer entity)
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync(Scripts.LazerScript.Insert(), entity);
        }

        public async Task Delete(int id)
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            await connection.ExecuteAsync(Scripts.LazerScript.Delete(), new {Id=id});
        }

        public async Task<IEnumerable<Lazer>> GetAll()
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var result = await connection.QueryAsync<Lazer>(Scripts.LazerScript.QueryAll());
            return result;
        }

        public async Task<Lazer> GetById(int id)
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var result = await connection.QueryFirstOrDefaultAsync<Lazer>(Scripts.LazerScript.QueryById(),new {Id=id});
            return result;
        }

        public async Task Update(Lazer entity)
        {
            using IDbConnection connection = new SqlConnection(_config.GetConnectionString("DefaultConnection"));
            var result = await connection.ExecuteAsync(Scripts.LazerScript.Update(), entity);
            return result;
        }
    }
}
