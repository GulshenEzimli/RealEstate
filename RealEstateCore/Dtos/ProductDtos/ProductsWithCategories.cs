using RealEstateCore.Dtos.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCore.Dtos.ProductDtos
{
    public class ProductsWithCategories
    {
        public int ProductId { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public int EmployeeId { get; set; }
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public bool CategoryStatus { get; set; }
        public ResultCategoryDto Category => new ResultCategoryDto()
        {
            CategoryId = CategoryId,
            CategoryName = CategoryName,
            CategoryStatus = CategoryStatus,
        };
    }
}
