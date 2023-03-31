using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net_assignment
{
    public  class ShowTable
    {
        public static void showtable()
        {
            SqlConnection con = new SqlConnection("data source= DESKTOP-TOATOCU; database= ishan; integrated security=SSPI");
            String command = "SELECT * FROM Student";

            SqlCommand cmd = new SqlCommand(command, con);

            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            Console.WriteLine("Id \t Name \t Age \t Department_ID \t Salary \t Technology");
            while (reader.Read())
            {
              Console.WriteLine(string.Format("{0} \t {1} \t {2} \t  {3}  \t {4} \t {5}", reader[0] , reader[1], reader[2], reader[3], reader[4] , reader[5]));
            }
            
            reader.Close();
        }

    }
}
