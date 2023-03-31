using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net_assignment
{
    public class Delete
    {
        public static void Deletedata()
        {
        Validation validate = new Validation();
            Console.WriteLine("enter the index you want to delete :");
            var  index =  validate.index();

            SqlConnection con = new SqlConnection("data source= DESKTOP-TOATOCU; database= ishan; integrated security=SSPI");


            con.Open();

            SqlCommand cmdo = new SqlCommand("Delete from Student where Id = @Id", con);

            cmdo.Parameters.AddWithValue("@Id", index);
            int value = cmdo.ExecuteNonQuery();

            if (value > 0)
            {
                Console.WriteLine("data deleted ");
            }
            else
            {
                Console.WriteLine("data is not deleted from database ");
            }
            con.Close();


        }

    }
}
