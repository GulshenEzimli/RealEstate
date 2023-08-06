using RealEstateCore.Dtos.Interfaces;

namespace RealEstateCore.Repositories
{
    public interface IDtoRepository<T> where T : IDto
    {
        Task<List<T>> GetAllAsync();
    }
}
