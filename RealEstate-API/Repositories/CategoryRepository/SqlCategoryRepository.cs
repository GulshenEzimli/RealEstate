using Dapper;
using RealEstate_API.Models.DapperContext;
using RealEstateCore.Dtos.CategoryDtos;

namespace RealEstate_API.Repositories.CategoryRepository
{
    public class SqlCategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public SqlCategoryRepository(Context context)
        {
            _context = context;
        }
        public async Task<List<ResultCategoryDto>> GetAllAsync()
        {
            var query = "select * from Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDto>(query);
                return values.ToList();
            }
        }
    }
}
