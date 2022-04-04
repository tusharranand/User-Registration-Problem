using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_Test
{
    public class Validation
    {
        public Regex First_Name_Regex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex Last_Name_Regex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        public Regex Email_Regex = new Regex(@"^[A-Za-z0-9]+([.+-][A-Za-z0-9]+)*@[A-Za-z0-9]+[.][a-z]{2,}([.][a-z]{2,})?$");
        public Regex Mobile_Regex = new Regex(@"^[0-9]{2}\s[0-9]{10}$");
        public Regex Password_Regex = new Regex(@"^(?=.*[A - Z])(?=.*[0 - 9])[a-zA-Z0-9]{7,}[\W]{1}$");

        public string Test_First(string First_Name)
        {
            if (First_Name_Regex.IsMatch(First_Name))
                return "First Name is valid";
            else throw new CustomExceptions(CustomExceptions.exceptionType.INVALID_FIRST_NAME, 
                "\nMinimum length three characters \nFirst letter should be capital");
        }
        public string Test_Last(string Last_Name)
        {
            if (Last_Name_Regex.IsMatch(Last_Name))
                return "Last Name is valid";
            else throw new CustomExceptions(CustomExceptions.exceptionType.INVALID_LAST_NAME, 
                "\nMinimum length three characters \nFirst letter should be capital");
        }
        public string Test_Email(string Email) 
        {
            if (Email_Regex.IsMatch(Email))
                return "Email is valid";
            else throw new CustomExceptions(CustomExceptions.exceptionType.INVALID_EMAIL, 
                "\nMust start with a character or a number \nMust contain @ character " +
                "\nAtleast one character should preceed @ \nMust contain period after @ " +
                "\nAtleast one character between @ and period \nAtleast two characters " +
                "after period");
        }
        public string Test_Mobile(string Mobile)
        {
            if (Mobile_Regex.IsMatch(Mobile))
                return "Mobile Number is valid";
            else throw new CustomExceptions(CustomExceptions.exceptionType.INVALID_MOBILE_NUMBER, 
                "\nFirst two digits must be country code \nFlollowed by a space \nFollowed by " +
                "a ten digit number");
        }
        public string Test_Pass(string Password)
        {
            if (Password_Regex.IsMatch(Password))
                return "Password is valid";
            else throw new CustomExceptions(CustomExceptions.exceptionType.INVALID_PASSWORD, 
                "\nMinimum eight characters \nAtleast one Uppercase character \nAtleast one " +
                "number \nFollowed by exactly one special character");
        }
    }
}
