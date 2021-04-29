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
        /// Validate MobileNumber
        /// </summary>
        [TestMethod]
        [DataRow("91 9146269635")]
        [DataRow("91 9856325698")]
        [DataRow("91 9865321456")]

        public void Given__Valid_MobileNumber_ShouldReturnTrue(string validMobile)
        {
            try
            {
                string result = userDetailsPattern.ValidateMobileNumber(validMobile);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Mobile Number", e.Message);
            }
        }

        /// <summary>
        /// passing invalid mobile number patterns should return invalid mobile number
        /// </summary>
        [TestMethod]
        [DataRow("91 9976655")]
        [DataRow("91 776655")]
        [DataRow("91 8776655")]
        [DataRow("91 976655")]
        [DataRow("91 98776655")]
        [DataRow("91 988776655")]
        public void GivenInvalidMobileNumber_ShouldReturnFalse(string invalidMobile)
        {
            try
            {
                string result = userDetailsPattern.ValidateMobileNumber(invalidMobile);

            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid mobile number", e.Message);
            }
        }
    }
}