using DN.RepoAdo.Application.Commands;
using DN.RepoAdo.Domain.DomainValidation;
using System.Collections.Generic;

namespace DN.RepoAdo.Application.Interfaces
{
    public interface IStoreAppService
    {
        ValidationResult CreateNewStore(CreatedStore command);
        IEnumerable<GridStore> GetAll();
    }
}
