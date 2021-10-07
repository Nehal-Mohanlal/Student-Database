using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data; 


namespace yeayeay
{
    class Datahandler
    {
        //DataSet dsStuds = new DataSet();
        //SqlDataAdapter daStudents = new SqlDataAdapter(); 

        static string connectionString = @"Data Source=DESKTOP-1CTOP33;Initial Catalog=StudDetails;Integrated Security=True";
        SqlConnection sconnection = new SqlConnection(connectionString);

        public string CheckCon()
        {
            sconnection.Open();
            Console.WriteLine("open");
            sconnection.Close();
            return "opened successfully";

        }


        //public DataSet disStudents()
        //{
        //    DataSet dsStuds = new DataSet();
        //    SqlDataAdapter daStudents = new SqlDataAdapter("SELECT * FROM S_Details", sconnection);
        //    daStudents.Fill(dsStuds, "S_Details");

        //    return dsStuds; 


        //}

        public DataTable DisplayStudents()
        {
            string qry1 = "Select * From S_Details";

            SqlDataAdapter sqda = new SqlDataAdapter(qry1, sconnection);

            DataTable dt = new DataTable();

            sqda.Fill(dt);

            return dt; 

        }



    }
}
