using DN.RepoAdo.Application.Interfaces;
using System;
using System.Collections.Generic;

namespace DN.RepoAdo.Application.IoC
{
    public static class Module
    {
        public static Dictionary<Type, Type> GetTypes()
        {
            var dic = new Dictionary<Type, Type>();
            dic.Add(typeof(IAppServiceBase), typeof(AppServiceBase));
            dic.Add(typeof(IStoreAppService), typeof(StoreAppService));
            return dic;
        }
    }
}
