using System;

namespace Regex_Test
{
    public class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Regstration Program");
            Validation validation = new Validation();
            Console.WriteLine("Enter a Number to check for: ");
            Console.WriteLine("1 - Valid First Name");
            Console.WriteLine("2 - Valid Second Name");
            Console.WriteLine("3 - Valid Email Address");
            Console.WriteLine("4 - Valid Phone Number");
            Console.WriteLine("5 - Valid Password");
            int Control = Convert.ToInt32(Console.ReadLine());
            switch (Control)
            {
                case 1:
                    Console.Write("Enter First Name: ");
                    string First_Name = Console.ReadLine();
                    Console.WriteLine(validation.Test_First(First_Name)); 
                    break;
                case 2:
                    Console.Write("Enter Last Name: ");
                    string Last_Name = Console.ReadLine();
                    Console.WriteLine(validation.Test_Last(Last_Name)); 
                    break;
                case 3:
                    Console.Write("Enter Email: ");
                    string Email = Console.ReadLine();
                    Console.WriteLine(validation.Test_Email(Email)); 
                    break;
                case 4:
                    Console.Write("Enter Mobile Number: ");
                    string Mobile = Console.ReadLine();
                    Console.WriteLine(validation.Test_Email(Mobile));
                    break;
                case 5:
                    Console.Write("Enter Password: ");
                    string Password = Console.ReadLine();
                    Console.WriteLine(validation.Test_Email(Password));
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }
        }
    }
}