using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControl
{
    class DBHelper
    {
        /// <summary>
        /// Returns the connection string to the method that calls it.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            return new SqlConnection(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=StreetsListDB;Integrated Security=True");
        }
    }
}
