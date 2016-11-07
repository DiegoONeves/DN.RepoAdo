using DN.RepoAdo.Domain.DomainValidation;
using DN.RepoAdo.Domain.Entities;
using System.Collections;
using System.Collections.Generic;

namespace DN.RepoAdo.Domain.Contracts.Services
{
    public interface IStoreService
    {
        ValidationResult CreateNewStore(Store store);
        IEnumerable<Store> GetAll();
    }
}
