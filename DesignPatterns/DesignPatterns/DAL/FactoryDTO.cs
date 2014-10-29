using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5Demo.DTO
{
    public enum DataProviderType
    {
        Postgres,
        mssql
    }
    public abstract class DTOFactory
    {
        public abstract DTO GetDataAccessLayer(DataProviderType dataProviderType);
    }

    public class DbDTO : DTOFactory
    {
        public override DTO GetDataAccessLayer(DataProviderType dataProviderType)
        {
            switch (dataProviderType)
            {
                case DataProviderType.Postgres : return new MyPostgreSQLDTO();
                case DataProviderType.mssql : return new MySQLDTO();
                default: throw new ArgumentException("Invalid DAL provider type.");
            }
        }
    }

}