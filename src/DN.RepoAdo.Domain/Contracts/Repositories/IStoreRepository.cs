using DN.RepoAdo.Domain.Entities;
using System.Collections.Generic;

namespace DN.RepoAdo.Domain.Contracts.Repositories
{
    public interface IStoreRepository
    {
        void Add(Store store);
        void Update(Store store);
        IEnumerable<Store> GetAll();
        void Remove(int id);
        Store GetById(int id);
        Store GetByDistrictName(string districtName);
    }
}
