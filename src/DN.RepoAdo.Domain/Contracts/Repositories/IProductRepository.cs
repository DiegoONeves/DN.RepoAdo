using DN.RepoAdo.Domain.Entities;
using System.Collections.Generic;

namespace DN.RepoAdo.Domain.Contracts.Repositories
{
    public interface IProductRepository
    {
        void Add(Product product);
        void Update(Product product);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Remove(int id);
    }
}
