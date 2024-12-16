using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public Task CreateProdcutAsync(CreateProductDto createProductDto)
        {
            throw new NotImplementedException();
        }
        public Task DeleteProdcutAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task GetByProductIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<List<ResultProductDto>> GetResultProductsAsync()
        {
            throw new NotImplementedException();
        }
        public Task UpdateProdcutAsync(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
