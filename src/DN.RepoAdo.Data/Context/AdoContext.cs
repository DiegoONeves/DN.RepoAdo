using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;

namespace DN.RepoAdo.Data.Context
{
    public class AdoContext
    {
        private const string CONNECTION_STRING_KEY = "ConnectionString";
        public SqlConnection Connection { get; set; }
        public SqlTransaction Transaction { get; set; }

        public AdoContext(IConfigurationRoot configuration)
        {
            var connectionString = configuration.GetSection(CONNECTION_STRING_KEY);

            if (string.IsNullOrWhiteSpace(connectionString.Value))
                throw new ArgumentNullException("Connection string not found!");

            Connection = new SqlConnection(connectionString.Value);
            Connection.Open();
        }

    }
}
