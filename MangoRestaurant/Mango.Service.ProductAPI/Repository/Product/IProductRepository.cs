using Mango.Service.ProductAPI.Repository.Dto;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Mango.Service.ProductAPI.Repository.Product
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        Task<ProductDto> GetProductById(int productId);
        Task<ProductDto> CreateUpdateProduct(ProductDto product);
        Task<bool> DeleteProduct(int productId);
    }
}
