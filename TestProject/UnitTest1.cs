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

        [Test]
        public void WhenGiven_Proper_FirstName_ShouldReturn_Valid()
        {
            Result = validation.Test_First("Tushar");
            Assert.AreEqual("First Name is valid", Result);
        }
        [Test]
        public void WhenGiven_Proper_LastName_ShouldReturn_Valid()
        {
            Result = validation.Test_Last("Anand");
            Assert.AreEqual("Last Name is valid", Result);
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
        public void WhenGiven_Proper_Email_ShouldReturn_Valid(string Email)
        {
            Result = validation.Test_Email(Email);
            Assert.AreEqual("Email is valid", Result);
        }
        [Test]
        public void WhenGiven_Proper_MobileNumber_ShouldReturn_Valid()
        {
            Result = validation.Test_Mobile("91 6642616716");
            Assert.AreEqual("Mobile Number is valid", Result);
        }
        [Test]
        public void WhenGiven_Proper_Password_ShouldReturn_Valid()
        {
            Result = validation.Test_Pass("ABCd6fg9#");
            Assert.AreEqual("Password is valid", Result);
        }
    }
}