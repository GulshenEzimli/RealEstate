using RealEstateCore.Repositories.CategoryRepository;
using RealEstateCore.Repositories.ProductRepository;

namespace RealEstateCore.Repositories.UnitOfWork
{
    public class SqlUnitOfWork : IUnitOfWork
    {
        private readonly string _connectionString;
        public SqlUnitOfWork(string connectionString)
        {
            _connectionString = connectionString;
        }
        public ICategoryRepository CategoryRepository => new SqlCategoryRepository(_connectionString);
        public IProductRepository ProductRepository => new SqlProductRepository(_connectionString);
    }
}
