using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;

namespace CHome.Database
{
    public class Connector : IDisposable
    {
        private SqlConnection _sqlConnection = null;

        internal Connector()
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

        internal void Open()
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

        internal void Close()
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

        internal SqlCommand SqlCommandText(string sqlStatement)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand(sqlStatement, _sqlConnection);
                sqlCommand.CommandType = System.Data.CommandType.Text;
                return sqlCommand;
            }
            catch
            {
                throw;
            }

        }

    }
}
