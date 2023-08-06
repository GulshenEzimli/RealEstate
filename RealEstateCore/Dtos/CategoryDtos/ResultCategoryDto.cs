using RealEstateCore.Dtos.Interfaces;

namespace RealEstateCore.Dtos.CategoryDtos
{
    public class ResultCategoryDto : IDto
    {
        public int Id { get; set; }
        public string? CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
    }
}
