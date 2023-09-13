using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojinhaServer.Collections;

namespace LojinhaServer.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>>GetAllAsync();
        Task<Product>GetByIdAsync(string id);
        Task CreateAsync(Product product);
        Task UpdateAsync(Product product1);
        Task DeleteAsync(string id);
    }
}