using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Npgsql;


namespace MVC5Demo.DTO
{
    public class MyPostgreSQLDTO:DTO
    {
        public MyPostgreSQLDTO()
        {
        }

        public  MyPostgreSQLDTO(string ConnectinString)
        {
            this.ConnectionString = String.Format("Server={0};Port={1};" +"User Id={2};Password={3};Database={4};","localhost", "5432", "postgres", "s@1", "postgres");
        }

        public override System.Data.IDbConnection GetConnection()
        {
            return new  NpgsqlConnection();
        }

        public override System.Data.IDbCommand GeCommand()
        {
            return new NpgsqlCommand();
        }

        public override System.Data.IDbDataAdapter GetDataAdapter()
        {
            return new NpgsqlDataAdapter();
        }
    }
}