using Dapper;
using RealEstate_API.Dtos.CategoryDtos;
using RealEstate_API.Models.DapperContext;

namespace RealEstate_API.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;
        public CategoryRepository(Context context)
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
