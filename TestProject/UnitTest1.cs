using Regex_Test;
using NUnit.Framework;

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
        [Test]
        public void WhenGiven_Proper_Email_ShouldReturn_Valid()
        {
            Result = validation.Test_Email("TusharrAnand@gmail.com");
            Assert.AreEqual("Email is valid", Result);
        }
        [Test]
        public void WhenGiven_Proper_MobileNumber_ShouldReturn_Valid()
        {
            Result = validation.Test_Mobile("91 9547614523");
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