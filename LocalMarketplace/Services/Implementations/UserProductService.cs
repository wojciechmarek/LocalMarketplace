﻿using LocalMarketplace.Models.DTOs;
using LocalMarketplace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalMarketplace.Services.Implementations
{
    public class ProductService : IUserProductService
    {
        public Task AddProductAsync(ProductAdd product)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductGet>> GetAllProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ProductGet> GetProductByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task RemoveProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(ProductAdd product)
        {
            throw new NotImplementedException();
        }
    }
}