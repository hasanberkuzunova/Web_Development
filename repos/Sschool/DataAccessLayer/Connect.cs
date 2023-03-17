using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connect
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-4SDT4VI\SQLEXPRESS;Initial Catalog=DBO_SummerSchool;Integrated Security=True");

    
            }
}
