using RealEstateCore.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstateCore.Dtos.ProductDtos
{
    public class ProductDto :IDto
    {
        public int ProductId { get; set; }
        public string? Title { get; set; }
        public decimal Price { get; set; }
        public string? City { get; set; }
        public string? District { get; set; }
        public string? Address { get; set; }
        public string? Description { get; set; }
        public int ProductCategoryId { get; set; }
        public int EmployeeId { get; set; }

    }
}
