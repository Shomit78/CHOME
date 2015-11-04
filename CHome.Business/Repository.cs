using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CHome.Database;
using CHome.Business.Entities;

namespace CHome.Business
{
    public class Repository
    {
        public List<Candidate> Candidates()
        {
            try
            {
                List<Candidate> candidates = new List<Candidate>();
                DataAdapter dataAdapter = new DataAdapter();
                SqlDataReader reader = dataAdapter.ExecuteSqlStatement("");
                while (reader.Read())
                {
                    Candidate candidate = new Candidate();
                    candidate.Id = reader.
                }
                return candidates;
            }
            catch
            {
                throw;
            }
        }
    }
}
