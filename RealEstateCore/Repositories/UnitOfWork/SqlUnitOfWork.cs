using RealEstateCore.Repositories.CategoryRepository;

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
    }
}
