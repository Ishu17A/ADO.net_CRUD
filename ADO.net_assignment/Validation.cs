using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADO.net_assignment
{
    public class Validation
    {

        public string checkname(string name)
        {
            while (!Regex.Match(name, "^[A-Za-z\\s]+$").Success)
            {
                Console.WriteLine("Invalid name");
                name = Console.ReadLine();

            }
            return name;
        }


        public int index()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("enter the valid input pls");
            }
            return id;
        }

        public int checkid()
        {
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("enter the valid input pls");
            }
            return id;
        }

        public string technology(string technology)
        {


            while (!Regex.Match(technology, "^[A-Za-z\\s]+$").Success)
            {
                Console.WriteLine("Invalid technology");
                technology = Console.ReadLine();

            }
            return technology;

        }



    }
}
