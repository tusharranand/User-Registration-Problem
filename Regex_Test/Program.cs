﻿using System;

namespace Regex_Test
{
    class program
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
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Invalid Entry");
                    break;
            }

        }
    }
}