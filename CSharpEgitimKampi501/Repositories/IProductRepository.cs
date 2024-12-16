﻿using CSharpEgitimKampi501.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi501.Repositories
{
    public interface IProductRepository
    {
        Task<List<ResultProductDto>> GetResultProductsAsync();
        Task CreateProdcutAsync(CreateProductDto createProductDto);
        Task UpdateProdcutAsync(UpdateProductDto updateProductDto);
        Task DeleteProdcutAsync(int id);
        Task GetByProductIdAsync(int id);
    }
}
