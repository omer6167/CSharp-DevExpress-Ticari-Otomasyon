using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Ticari_Otomasyon
{
    internal class Database
    {
        public SqlConnection Connection() {
            SqlConnection sqlConnection = new SqlConnection(@"Data Source=OKUCUK\SQLEXPRESS;Initial Catalog=SalonOtomasyon;Integrated Security=True");
            sqlConnection.Open();
            return sqlConnection; 
        }
    }
}
