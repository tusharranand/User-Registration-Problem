using Regex_Test;
using NUnit.Framework;
using System.Text.RegularExpressions;

namespace TestProject
{
    public class Tests
    {
        program program;
        Validation validation;
        string Result;
        [SetUp]
        public void Setup()
        {
            validation = new Validation();
            program = new program();
        }

        [TestCase("Tushar")]
        [TestCase("tushar")]
        public void WhenGiven_Proper_FirstName_ShouldReturn_Valid(string firstName)
        {
            try
            {
                Result = validation.Test_First(firstName);
                Assert.AreEqual("First Name is valid", Result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("\nMinimum length three characters \nFirst letter should be " +
                    "capital\n", ex.Message);
            }
        }
        [TestCase("Anand")]
        [TestCase("An")]
        public void WhenGiven_Proper_LastName_ShouldReturn_Valid(string lastName)
        {
            try
            {
                Result = validation.Test_Last(lastName);
                Assert.AreEqual("Last Name is valid", Result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("\nMinimum length three characters \nFirst letter should be " +
                    "capital\n", ex.Message);
            }
        }
        [TestCase("abc@yahoo.com")]
        [TestCase("abc-100@yahoo.com")]
        [TestCase("abc.100@yahoo.com")]
        [TestCase("abc111@abc.com")]
        [TestCase("abc-100@abc.net")]
        [TestCase("abc.100@abc.com.au")]
        [TestCase("abc@1.com")]
        [TestCase("abc@gmail.com.com")]
        [TestCase("abc+100@gmail.com")]
        [TestCase("abc-100@.com")]
        public void WhenGiven_Proper_Email_ShouldReturn_Valid(string Email)
        {
            try
            {
                Result = validation.Test_Email(Email);
                Assert.AreEqual("Email is valid", Result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("\nMust start with a character or a number \nMust contain @ " +
                    "character \nAtleast one character should preceed @ \nMust contain period " +
                    "after @ \nAtleast one character between @ and period \nAtleast two " +
                    "characters after period\n", ex.Message);
            }
        }
        [TestCase("91 6642616716")]
        [TestCase("3215478888")]
        public void WhenGiven_Proper_MobileNumber_ShouldReturn_Valid(string mobile)
        {
            try
            {
                Result = validation.Test_Mobile(mobile);
                Assert.AreEqual("Mobile Number is valid", Result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("\nFirst two digits must be country code \nFlollowed by a space " +
                    "\nFollowed by a ten digit number\n", ex.Message);
            }
        }
        [TestCase("ABCd6fg9#")]
        [TestCase("JddbfOOpo")]
        public void WhenGiven_Proper_Password_ShouldReturn_Valid(string password)
        {
            try
            {
                Result = validation.Test_Pass(password);
                Assert.AreEqual("Password is valid", Result);
            }
            catch (CustomExceptions ex)
            {
                Assert.AreEqual("\nMinimum eight characters \nAtleast one Uppercase character " +
                    "\nAtleast one number \nFollowed by exactly one special character\n", ex.Message);
            }
        }
    }
}