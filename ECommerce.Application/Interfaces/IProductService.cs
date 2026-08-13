using ECommerce.Application.DTOs.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
        Task<ProductDto> CreateAsync(ProductDto productDto);
        Task<ProductDto> GetByIdAsync(int id);
        Task<ProductDto?> UpdateAsync(int id, ProductDto productDto);
        Task<bool> DeleteAsync(int id);
    }
}
