using ECommerce.Application.DTOs.Products;
using ECommerce.Application.Interfaces;
using ECommerce.Domain.Entities;
using System.Net;


namespace ECommerce.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductDto> CreateAsync(ProductDto productDto)
        {
            var product = new Product
            {
                Name = productDto.Name,
                Description = productDto.Description,
                Price = productDto.Price,
                Stock = productDto.Stock,
                ImageUrl = productDto.ImageUrl,
            };
            
            var createdProduct = await _repository.AddAsync(product);

            return new ProductDto
            {
                Id = createdProduct.Id,
                Name = createdProduct.Name,
                Description = createdProduct.Description,
                Price = createdProduct.Price,
                Stock = createdProduct.Stock,
                ImageUrl = createdProduct.ImageUrl

            };
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var product = await _repository.GetById(id);
            if (product == null)
                return false;

            await _repository.DeleteAsync(id);
            return true;
        }

        public async Task<IEnumerable<ProductDto>> GetAllAsync()
        {
            var products = await _repository.GetAll();
            return products.Select(product => new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                ImageUrl = product.ImageUrl,
            });
        }

        public async Task<ProductDto> GetByIdAsync(int id)
        {
            var productData = await _repository.GetById(id);
            if (productData == null)
            {
                return null;
            }
            return new ProductDto
            {
                Id = productData.Id,
                Name = productData.Name,
                Description = productData.Description,
                Price = productData.Price,
                Stock = productData.Stock,
                ImageUrl = productData.ImageUrl,
            };
        }

        public async Task<ProductDto?> UpdateAsync(int id, ProductDto productDto)
        {
            var product = await _repository.GetById(id);
            if (product == null)
            {
                return null;
            }
            else
            {
                product.Name=productDto.Name;
                product.Description = productDto.Description;
                product.Price = productDto.Price;
                product.Stock = productDto.Stock;
                product.ImageUrl = productDto.ImageUrl;
                await _repository.UpdateAsync(product);
            }

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Stock = product.Stock,
                ImageUrl = product.ImageUrl
            };
        }
    }
}
