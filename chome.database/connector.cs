using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace Chome.Database
{
    public class Connector
    {
        private SqlConnection _sqlConnection = null;

        public Connector()
        {
            try
            {
                _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings[
                    Constants.ApplicationDatabaseConnectionStringName].ToString());
            }
            catch
            {
                throw;
            }
        }

        public void Open()
        {
            try
            {
                if (_sqlConnection != null)
                {
                    _sqlConnection.Open();
                }
                else
                {
                    throw new NullReferenceException("SQL Connection is null");
                }
            }
            catch
            {
                throw;
            }
        }

        public void Close()
        {
            try
            {
                if (_sqlConnection != null)
                {
                    _sqlConnection.Close();
                }
                else
                {
                    throw new NullReferenceException("SQL Connection is null");
                }
            }
            catch
            {
                throw;
            }
        }

        public void Dispose()
        {
            try
            {
                if (_sqlConnection != null)
                {
                    _sqlConnection.Close();
                    _sqlConnection.Dispose();
                }
                else
                {
                    throw new NullReferenceException("SQL Connection is null");
                }
            }
            catch
            {
                throw;
            }
        }

    }
}
