using RealEstateCore.Dtos.Interfaces;

namespace RealEstateCore.Repositories
{
    public interface IDtoRepository<T> where T : IDto
    {
        Task<List<T>> GetAllAsync();
        void Create(T dto);
        void Delete(int id);
        void Update(T dto); 
        Task<T> GetById(int id);    
    }
}
