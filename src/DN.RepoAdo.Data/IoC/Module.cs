using DN.RepoAdo.Data.Context;
using DN.RepoAdo.Data.Interfaces;
using DN.RepoAdo.Data.Repositories;
using DN.RepoAdo.Data.Transactions;
using DN.RepoAdo.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;

namespace DN.RepoAdo.Data.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();
            dic.Add(typeof(IUnityOfWork), typeof(UnityOfWork));
            dic.Add(typeof(AdoContext), typeof(AdoContext));
            dic.Add(typeof(IStoreRepository), typeof(StoreRepository));
            return dic;
        }
    }
}
