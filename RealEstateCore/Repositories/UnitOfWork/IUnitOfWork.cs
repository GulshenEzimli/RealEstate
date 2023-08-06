using RealEstateCore.Repositories.CategoryRepository;

namespace RealEstateCore.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
    }
}
