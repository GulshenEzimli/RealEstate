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

        public async void Create(ResultCategoryDto dto)
        {
            string query = $"insert into Category values(@categoryName,@categoryStatus)";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", dto.CategoryName);
            parameters.Add("@categoryStatus", dto.CategoryStatus);
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(query, parameters); 
            }
        }

        public async Task<List<ResultCategoryDto>> GetAllAsync()
        {
            string query = "select * from Category";
            using (var connection = new SqlConnection(_connectionString))
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
        public async void Delete(int id)
        {
            string query = "delete from Category where CategoryId=@id";
            var parameters = new DynamicParameters();   
            parameters.Add("@id", id);
            using(var connection = new SqlConnection(_connectionString)) 
            { 
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async void Update(ResultCategoryDto dto)
        {
            string query = "update Category set CategoryName=@categoryName, CategoryStatus=@categoryStatus where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryName", dto.CategoryName);
            parameters.Add("@categoryStatus", dto.CategoryStatus);
            parameters.Add("@categoryId", dto.CategoryId);
            using(var connection = new SqlConnection(_connectionString))
            {
                await connection.ExecuteAsync(query,parameters);
            }
        }

        public async Task<ResultCategoryDto> GetById(int id)
        {
            string query = "select * from Category where CategoryId=@categoryId";
            var parameters = new DynamicParameters();
            parameters.Add("@categoryId", id);
            using (var connection = new SqlConnection(_connectionString))
            {
                var value = await connection.QueryFirstOrDefaultAsync<ResultCategoryDto>(query, parameters);
                return value;
            }

        }
    }
}
