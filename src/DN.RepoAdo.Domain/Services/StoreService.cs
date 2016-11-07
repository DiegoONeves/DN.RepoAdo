using System;
using System.Collections.Generic;
using DN.RepoAdo.Domain.Contracts.Repositories;
using DN.RepoAdo.Domain.Contracts.Services;
using DN.RepoAdo.Domain.DomainValidation;
using DN.RepoAdo.Domain.Entities;

namespace DN.RepoAdo.Domain.Services
{
    internal class StoreService : IStoreService
    {
        private readonly IStoreRepository storeRepo;
        private ValidationResult validationResult = new ValidationResult();
        public StoreService(IStoreRepository storeRepo)
        {
            this.storeRepo = storeRepo;
        }
        public ValidationResult CreateNewStore(Store store)
        {
            var storeInDb = storeRepo.GetByDistrictName(store.DistrictName);

            if (storeInDb != null)
                validationResult.AddError(new ValidationError($"A loja da {store.DistrictName} já foi cadastrada.", MessageCategory.BusinessRule));

            if (validationResult.IsValid)
                storeRepo.Add(store);

            return validationResult;
        }

        public IEnumerable<Store> GetAll()
        {
            return storeRepo.GetAll();
        }
    }
}
