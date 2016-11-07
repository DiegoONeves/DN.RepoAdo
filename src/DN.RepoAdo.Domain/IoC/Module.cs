using DN.RepoAdo.Domain.Contracts.Services;
using DN.RepoAdo.Domain.Services;
using System;
using System.Collections.Generic;

namespace DN.RepoAdo.Domain.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();
            dic.Add(typeof(IStoreService), typeof(StoreService));
            return dic;
        }
    }
}
