using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net_assignment
{
    public class Add
    {




        public static void add()
        {
        Validation val = new Validation();


            Console.WriteLine("enter the id :");
            var id = val.index();
            Console.WriteLine("enter the name :");
            var name = val.checkname( Console.ReadLine());
            Console.WriteLine("enter the age :");
            var age = val.index();
            Console.WriteLine("enter the department id :");
            var Department_id = val.index();
            Console.WriteLine("enter the salary :");
            var salary = val.index();
            Console.WriteLine("enter the technology :");
            var Technology =  val.technology(Console.ReadLine());

            try
            {

                SqlConnection con = new SqlConnection("data source= DESKTOP-TOATOCU; database= ishan; integrated security=SSPI");
                String command = "INSERT INTO Student(Id, Name, Age, DepartmentID, Salary, Technology) VALUES (@id , @name, @age, @Department_id , @salary, @Technology)";

                SqlCommand cmd = new SqlCommand(command, con);

                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@Department_id", Department_id);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@Technology", Technology);

                con.Open();

                int value = cmd.ExecuteNonQuery();

                if (value > 0)
                {
                    Console.WriteLine("Data added successfully!");
                }
                else
                {
                    Console.WriteLine("Data is not added");
                }

                con.Close();

            }

            catch (Exception ex)
            {
                Console.WriteLine("something went wrong" + ex);
            }
        }

    }
}
