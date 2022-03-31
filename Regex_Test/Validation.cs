using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Test
{
    class Validation
    {
        public Regex First_Name_Regex = new Regex(@"^[A-Z][A-Za-z]{2,}$");

        public void Test_First(string First_Name)
        {
            if (First_Name_Regex.IsMatch(First_Name))
                Console.WriteLine("First Name is valid");
            else Console.WriteLine("First Name is not valid");
        }
    }
}
