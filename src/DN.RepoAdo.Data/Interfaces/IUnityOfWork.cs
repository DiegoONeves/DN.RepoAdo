using System;

namespace DN.RepoAdo.Data.Interfaces
{
    public interface IUnityOfWork
    {
        void BeginTransaction();
        void RollBack();
        void Commit();
    }
}
