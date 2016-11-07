using DN.RepoAdo.Domain.Contracts.Repositories;
using DN.RepoAdo.Domain.Entities;
using System;
using System.Collections.Generic;
using DN.RepoAdo.Data.Context;
using System.Data;
using DN.RepoAdo.Data.Extensions;

namespace DN.RepoAdo.Data.Repositories
{
    public class StoreRepository : IStoreRepository
    {
        private readonly AdoContext context;
        public StoreRepository(AdoContext context)
        {
            this.context = context;
        }

        public void Add(Store store)
        {

            using (var command = new CommandContext(context).Command)
            {
                //command.Transaction = context.Transaction;
                command.CommandText = "pr_Store_create";
                command.CommandType = CommandType.StoredProcedure;
                command.AddParameter("@DistrictName", store.DistrictName);
                command.AddParameter("@IsActive", store.IsActive);

                using (var reader = command.ExecuteReader())
                    while (reader.Read())
                        store.Load((int)reader["StoreId"], (string)reader["DistrictName"], (bool)reader["IsActive"]);
            }
        }

        public void Update(Store store)
        {

        }

        public IEnumerable<Store> GetAll()
        {
            var resultQuery = new List<Store>();
            using (var command = new CommandContext(context).Command)
            {
                command.CommandText = "pr_Store_get_All";
                command.CommandType = CommandType.StoredProcedure;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var store = new Store();
                        store.Load((int)reader["StoreId"], (string)reader["DistrictName"], (bool)reader["IsActive"]);
                        resultQuery.Add(store);
                    }
                }
            }

            return resultQuery;
        }

        public Store GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {

        }

        public Store GetByDistrictName(string districtName)
        {
            using (var command = new CommandContext(context).Command)
            {

                command.CommandText = "pr_Store_get_byDistrictName";
                command.CommandType = CommandType.StoredProcedure;
                command.AddParameter("@DistrictName", districtName);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            var store = new Store();
                            store.Load((int)reader["StoreId"], (string)reader["DistrictName"], (bool)reader["IsActive"]);
                            return store;
                        }
                    }
                    return null;
                }
            }
        }
    }
}
