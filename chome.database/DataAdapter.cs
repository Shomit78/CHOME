using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CHome.Database
{
    public class DataAdapter
    {

        private Connector _connector = null;

        public DataAdapter()
        {

        }

        public SqlDataReader ExecuteSqlStatement(string sqlStatement)
        {
            try
            {
                using (_connector = new Connector())
                {
                    _connector.Open();
                    SqlCommand sqlCommand = _connector.SqlCommandText(sqlStatement);
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    return sqlDataReader;
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
