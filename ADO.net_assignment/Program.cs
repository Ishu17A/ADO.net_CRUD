using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.net_assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
               
                int input1;
                Console.WriteLine("Please press " + "\n" +
                 "1-ADD" + "\n" +
                 "2-SHOW" + "\n" +
                 "3-DELETE" + "\n" +
                 "4-UPDATE" + "\n"
                 );

                while (!int.TryParse(Console.ReadLine(), out input1))
                {
                    Console.WriteLine("NOT The valid ");
                }

                switch (input1)
                {
                    case 1:
                        {
                            Add.add();
                            break;

                        }
                    case 2:
                        {

                            ShowTable.showtable();
                            break;
                        }
                    case 3:
                        {

                            Delete.Deletedata();
                            break;
                        }
                    case 4:
                        {

                            Update.updatedata();
                            break;

                        }
                    default:
                        Console.WriteLine("Enter the Valid Input");
                        break;
                }


            Console.ReadLine();
            }

        }
    }
}
