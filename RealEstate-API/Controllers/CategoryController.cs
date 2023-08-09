using Microsoft.AspNetCore.Mvc;
using RealEstateCore.Dtos.CategoryDtos;
using RealEstateCore.Repositories.UnitOfWork;

namespace RealEstate_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _db;
        public CategoryController(IUnitOfWork db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var values = await _db.CategoryRepository.GetAllAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(ResultCategoryDto dto)
        {
            _db.CategoryRepository.Create(dto);
            return Ok("Category added successfully!");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            _db.CategoryRepository.Delete(id);
            return Ok("Category deleted successfully");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(ResultCategoryDto dto)
        {
            _db.CategoryRepository.Update(dto);
            return Ok("Category updated successfully");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var value = await _db.CategoryRepository.GetById(id);
            return Ok(value);   
        }
    }
}
