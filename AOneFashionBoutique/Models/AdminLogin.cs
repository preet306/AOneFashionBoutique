using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AOneFashionBoutique.Models
{
    public class AdminLogin
    {
        public String QName { get; set; }
        public String QPassword { get; set; }

        SqlConnection sqlConn;
        String connection_String = "Data Source=DESKTOP-H0A99S7\\SQLEXPRESS;Initial Catalog=FashionBoutique;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;

        // this code is used to in the details of a prticuar query from the table using the sql statement with the help of where clause 
        public DataTable Login(String query)
        {
            DataTable tbl = new DataTable();


            sqlConn = new SqlConnection(connection_String);

            sqlConn.Open();
            sqlCmd = new SqlCommand(query, sqlConn);

            sqlDatareader = sqlCmd.ExecuteReader();

            tbl.Load(sqlDatareader);

            sqlConn.Close();
            return tbl;

        }



    }
}