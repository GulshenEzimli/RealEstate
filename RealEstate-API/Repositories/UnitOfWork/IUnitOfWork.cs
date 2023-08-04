using RealEstate_API.Repositories.CategoryRepository;

namespace RealEstate_API.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
    }
}
