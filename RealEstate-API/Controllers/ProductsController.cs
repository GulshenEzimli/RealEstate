using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstateCore.Repositories.UnitOfWork;

namespace RealEstate_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IUnitOfWork _db;
        public ProductsController(IUnitOfWork db)
        {
            _db = db;    
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _db.ProductRepository.GetAllAsync();
            return Ok(values);  
        }
        [HttpGet("ProductsWithCategories")]
        public async Task<IActionResult> GetAllProductsWithCategories()
        {
            var values = await _db.ProductRepository.GetProductsWithCategories();
            return Ok(values);
        }
    }
}
