using DN.RepoAdo.Application.Interfaces;
using DN.RepoAdo.Data.Interfaces;
using System;

namespace DN.RepoAdo.Application
{
    internal class AppServiceBase : IAppServiceBase
    {
        private IUnityOfWork uow;
        public AppServiceBase(IUnityOfWork uow)
        {
            this.uow = uow;
        }

        public void BeginTransaction()
        {
            uow.BeginTransaction();
        }

        public void Commit()
        {
            uow.Commit();
        }

        public void RollBack()
        {
            uow.RollBack();
        }
    }
}
