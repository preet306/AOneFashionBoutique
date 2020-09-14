using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AOneFashionBoutique.Models
{
    public class Contact
    {
        public String QName { get; set; }
        public String QEmail { get; set; }
        public String QSubject { get; set; }
        public String QMessage { get; set; }


        SqlConnection sqlConn;
        String connection_String = "Data Source=DESKTOP-H0A99S7\\SQLEXPRESS;Initial Catalog=FashionBoutique;Integrated Security=True";
        SqlCommand sqlCmd;
        SqlDataReader sqlDatareader;

        //this statement is related to insert delete update query that is the main statement of any database record 
        public void sendMessage(String Query)
        {

            sqlConn = new SqlConnection(connection_String);
            sqlConn.Open();


            sqlCmd = new SqlCommand(Query, sqlConn);
            sqlCmd.ExecuteNonQuery();

            sqlConn.Close();

        }


    }
}