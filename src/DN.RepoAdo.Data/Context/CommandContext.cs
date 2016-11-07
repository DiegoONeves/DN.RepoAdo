using System;
using System.Data.SqlClient;

namespace DN.RepoAdo.Data.Context
{
    public class CommandContext: IDisposable
    {
        public CommandContext(AdoContext adoContext)
        {
            Command = new SqlCommand();
            Command.CommandTimeout = 30;
            Command.Connection = adoContext.Connection;
            Command.Transaction = adoContext.Transaction;
        }

        public SqlCommand Command { get; set; }

        public void Dispose()
        {
            Command.Dispose();
        }
    }
}
