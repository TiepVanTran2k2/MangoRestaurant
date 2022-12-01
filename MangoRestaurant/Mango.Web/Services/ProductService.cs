using Mango.Web.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace Mango.Web.Services
{
    public class ProductService : BaseService, IProductService
    {
        private readonly IHttpClientFactory _clientFactory;
        public ProductService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _clientFactory = httpClientFactory;
        }
        public async Task<T> CreateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.POST,
                Data = productDto,
                AccessToken = "",
                Url = SD.ProductAPIBase + "api/products"
            });
        }

        public async Task<T> DeleteProductAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.DELETE,
                AccessToken = "",
                Url = SD.ProductAPIBase + $"api/products/{id}"
            });
        }

        public async Task<T> GetAllProductAsync<T>()
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                AccessToken = "",
                Url = SD.ProductAPIBase + "api/products"
            });
        }

        public async Task<T> GetProductByIdAsync<T>(int id)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.GET,
                AccessToken = "",
                Url = SD.ProductAPIBase + $"api/products/{id}"
            });
        }

        public async Task<T> UpdateProductAsync<T>(ProductDto productDto)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType = SD.ApiType.PUT,
                AccessToken = "",
                Data = productDto,
                Url = SD.ProductAPIBase+$"api/products"
            });
        }
    }
}
