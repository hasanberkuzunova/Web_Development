using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class SQLClass
{
    public SqlConnection connect()
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-4SDT4VI\SQLEXPRESS;Initial Catalog=DBO_Recipes;Integrated Security=True");
        connect.Open();
        return connect;
    }
}