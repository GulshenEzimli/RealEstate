using Dapper;
using Microsoft.Data.SqlClient;
using RealEstateCore.Dtos.CategoryDtos;

namespace RealEstateCore.Repositories.CategoryRepository
{
    public class SqlCategoryRepository : ICategoryRepository
    {
        private readonly string _connectionString;
        public SqlCategoryRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public async Task<List<ResultCategoryDto>> GetAllAsync()
        {
            var query = "select * from Category";
            using (var connection = new SqlConnection(_connectionString))
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
