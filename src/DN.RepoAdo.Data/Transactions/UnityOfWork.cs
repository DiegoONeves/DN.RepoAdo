using DN.RepoAdo.Data.Context;
using DN.RepoAdo.Data.Interfaces;
using System;

namespace DN.RepoAdo.Data.Transactions
{
    internal class UnityOfWork : IUnityOfWork
    { 
        AdoContext adoContext;
        public UnityOfWork(AdoContext adoContext)
        {
            this.adoContext = adoContext;
        }
        public void BeginTransaction()
        {
            adoContext.Transaction = adoContext.Connection.BeginTransaction();
        }

        public void Commit()
        {
            adoContext.Transaction.Commit();
            adoContext.Connection.Close();
        }

        public void RollBack()
        {
            adoContext.Transaction.Rollback();
            adoContext.Connection.Close();
        }
    }
}
