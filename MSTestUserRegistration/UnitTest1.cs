using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationMSTest;

namespace MSTestUserRegistration
{
    [TestClass]
    public class Test
    {
        private readonly UserDetail userDetailsPattern;
        //private readonly object DataRow;

        //parameterless constructor
        public Test()
        {
            userDetailsPattern = new UserDetail(); //object of UserDetail and store the userDetailsPattern variable
        }
         
        /// <summary>
        /// Validate Password
        /// </summary>
        [TestMethod]
        [DataRow("abc.20@yahoo.com")]
        [DataRow("abc.10@gmail.com")]
        [DataRow("abc.100@yahoo.com")]

        public void Given__Valid_Email_ShouldReturnTrue(string emailInvalid)
        {
            try
            {
                string result = userDetailsPattern.ValidateEmail(emailInvalid);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Email", e.Message);
            }
        }

        /// <summary>
        /// passing invalid Password patterns should return invalid Password
        /// </summary>
        [TestMethod]
        [DataRow("anki11@gmail.com.a12")]
        [DataRow("anki@gmail.com.12sa")]
        [DataRow("_anki@gmail.com")]
        public void GivenEmailId_WhenIsNotProper_ShouldReturnFalse(string emailInvalid)
        {
            try
            {
                string result = userDetailsPattern.ValidateEmail(emailInvalid);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid email id", e.Message);
            }
        }
    }

}