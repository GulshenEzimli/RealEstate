using RealEstate_API.Models.DapperContext;
using RealEstate_API.Repositories.CategoryRepository;

namespace RealEstate_API.Repositories.UnitOfWork
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private readonly Context _context;
        public SqlUnitOfWork(Context context)
        {
            _context = context;
        }
        public ICategoryRepository CategoryRepository => new SqlCategoryRepository(_context);
    }
}
