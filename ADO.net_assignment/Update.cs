using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net_assignment
{
    public class Update
    {

        public static void updatedata()
        {

            Validation validation = new Validation();

            Console.WriteLine("enter the index you want to edit :");
            /*        var index = int.Parse(Console.ReadLine());*/
            var index = validation.index();



            Console.WriteLine("enter the name :");
            var name = validation.checkname(Console.ReadLine());

            Console.WriteLine("enter the age :");
            var age = validation.index();

            Console.WriteLine("enter the department id :");
            var Department_id = validation.index();

            Console.WriteLine("enter the salary :");
            var salary = validation.index();

            Console.WriteLine("enter the technology :");
            var Technology = validation.technology(Console.ReadLine());


            SqlConnection con = new SqlConnection("data source= DESKTOP-TOATOCU; database= ishan; integrated security=SSPI");

            SqlCommand cmd = new SqlCommand("SELECT * FROM  Student WHERE  Id = @Id", con);
            cmd.Parameters.AddWithValue("Id", index);
            con.Open();

            SqlDataReader rdr = cmd.ExecuteReader();


            SqlCommand cmdo = new SqlCommand("UPDATE Student SET  Name = @name, Age = @age , DepartmentID =  @DepartmentID , Salary = @salary , Technology = @Technology where Id=@Id", con);


            cmdo.Parameters.AddWithValue("Name", name);
            cmdo.Parameters.AddWithValue("Age", age);
            cmdo.Parameters.AddWithValue("DepartmentID", Department_id);
            cmdo.Parameters.AddWithValue("Salary", salary);
            cmdo.Parameters.AddWithValue("Technology", Technology);

            cmdo.Parameters.AddWithValue("@Id", index);
            rdr.Close();

            int value = cmdo.ExecuteNonQuery();

            if (value > 0)
            {
                Console.WriteLine("edit is done");
            }
            else
            {
                Console.WriteLine("edit is not done");
            }





        }




    }


}
