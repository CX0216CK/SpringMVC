using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace 刘洋洋
{
    class DBhelp
    {
         private SqlConnection con;
        public SqlConnection Con
        {
            get
            {
                string Sqlcon = "Data Source=.;Initial Catalog=刘洋洋;User ID=sa;Password=";
                if (con == null)
                {
                    con = new SqlConnection(Sqlcon);
                }
                return con;
            }
        }
        public void Oper()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            else if (con.State == ConnectionState.Broken)
            {
                con.Close();
                con.Open();
            }
        }
        public void Close()
        {
            if (con.State == ConnectionState.Open || con.State == ConnectionState.Broken)
            {
                con.Close();
            }
        }


    }
}
    

