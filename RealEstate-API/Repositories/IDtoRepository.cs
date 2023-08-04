using RealEstate_API.Dtos.Interfaces;

namespace RealEstate_API.Repositories
{
    public interface IDtoRepository<T> where T : IDto
    {
        Task<List<T>> GetAllAsync();
    }
}
