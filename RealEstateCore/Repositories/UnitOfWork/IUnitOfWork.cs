using RealEstateCore.Repositories.CategoryRepository;
using RealEstateCore.Repositories.ProductRepository;

namespace RealEstateCore.Repositories.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryRepository { get; }
        IProductRepository ProductRepository { get; }   
    }
}
