using Dapper;
using Microsoft.Data.SqlClient;
using RealEstateCore.Dtos.ProductDtos;
using System;

namespace RealEstateCore.Repositories.ProductRepository
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly string _connectionString;
        public SqlProductRepository(string connectionString)
        {
            _connectionString = connectionString;
        }
        public void Create(ProductDto dto)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductDto>> GetAllAsync()
        {
            string query = "select * from Product";
            using(var connection = new SqlConnection(_connectionString))
            {
                var values = await connection.QueryAsync<ProductDto>(query);
                return values.ToList();
            }
        }

        public Task<ProductDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductsWithCategories>> GetProductsWithCategories()
        {
            string query = "select ProductId,Title,Price,City,District,Address,Description,EmployeeId," +
                           "CategoryId,CategoryName,CategoryStatus from Product inner join Category " +
                           "on Product.ProductCategoryId=Category.CategoryId";
            using (var connection = new SqlConnection(_connectionString))
            {
                var values = await connection.QueryAsync<ProductsWithCategories>(query);
                return values.ToList();
            }
        }

        public void Update(ProductDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
