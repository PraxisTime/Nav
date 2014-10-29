using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MVC5Demo.DTO
{
    public class MySQLDTO : DTO
    {
        public MySQLDTO()
        { }

        public MySQLDTO(string ConnectionString)
        {
            this.ConnectionString = "Data Source=(localdb)\v11.0; Initial Catalog=PersonsContext-20130727152805; Integrated Security=True; MultipleActiveResultSets=True; AttachDbFilename=|DataDirectory|PersonsContext-20130727152805.mdf";
        }


        public override System.Data.IDbConnection GetConnection()
        {
            return new SqlConnection();
        }

        public override System.Data.IDbCommand GeCommand()
        {
            return new SqlCommand();
        }

        public override System.Data.IDbDataAdapter GetDataAdapter()
        {
            return new SqlDataAdapter();
        }
    }
}