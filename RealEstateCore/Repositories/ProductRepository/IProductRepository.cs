using System;
using RealEstateCore.Dtos.ProductDtos;
using RealEstateCore.Repositories;

namespace RealEstateCore.Repositories.ProductRepository
{
    public interface IProductRepository : IDtoRepository<ProductDto>
    {
        Task<List<ProductsWithCategories>> GetProductsWithCategories();
    }
}
