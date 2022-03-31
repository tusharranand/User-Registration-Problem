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
        public Regex Last_Name_Regex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex Email_Regex = new Regex(@"^[A-Za-z]+(.[A-Za-z])*@[a-z]+[.][a-z]{2,}([.][a-z]{2,})?$");
        public Regex Mobile_Regex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex Password_Regex = new Regex(@"[A-Za-z]{8,}");

        public void Test_First(string First_Name)
        {
            if (First_Name_Regex.IsMatch(First_Name))
                Console.WriteLine("First Name is valid");
            else Console.WriteLine("First Name is not valid");
        }
        public void Test_Last(string Last_Name)
        {
            if (Last_Name_Regex.IsMatch(Last_Name))
                Console.WriteLine("Last Name is valid");
            else Console.WriteLine("Last Name is not valid");
        }
        public void Test_Email(string Email) // for abc.xyz@bl.co.in
        {
            if (Email_Regex.IsMatch(Email))
                Console.WriteLine("Email is valid");
            else Console.WriteLine("Email is not valid");
        }
        public void Test_Mobile(string Mobile)
        {
            if (Mobile_Regex.IsMatch(Mobile))
                Console.WriteLine("Mobile Number is valid");
            else Console.WriteLine("Mobile Number is not valid");
        }
        public void Test_Pass(string Password)
        {
            if (Password_Regex.IsMatch(Password))
                Console.WriteLine("Password is valid");
            else Console.WriteLine("Password is not valid");
        }
    }
}
