using DN.RepoAdo.Application.Commands;
using DN.RepoAdo.Application.Interfaces;
using DN.RepoAdo.Data.Interfaces;
using DN.RepoAdo.Domain.Contracts.Services;
using DN.RepoAdo.Domain.DomainValidation;
using DN.RepoAdo.Domain.Entities;
using System.Collections.Generic;

namespace DN.RepoAdo.Application
{
    internal class StoreAppService : AppServiceBase, IStoreAppService
    {
        private readonly IStoreService storeService;
        public StoreAppService(IUnityOfWork uow, IStoreService storeService)
            : base(uow)
        {
            this.storeService = storeService;
        }

        public ValidationResult CreateNewStore(CreatedStore command)
        {
            BeginTransaction();

            var store = new Store(command.DistrictName, command.IsActive);

            var result = storeService.CreateNewStore(store);

            if (result.IsValid)
                Commit();
            else
                RollBack();

            return result;
        }

        public IEnumerable<GridStore> GetAll()
        {
            foreach (var item in storeService.GetAll())
                yield return new GridStore
                {
                    Id = item.StoreId,
                    DistrictName = item.DistrictName,
                    IsActive = item.IsActive
                };
        }
    }
}
