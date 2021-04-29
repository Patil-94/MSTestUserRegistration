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
        /// Validate Last name
        /// </summary>
        [TestMethod]
        [DataRow("Khairnar")]
        [DataRow("Patil")]
        [DataRow("Aher")]
        [DataRow("Shelke")]


        public void Given_LasttName_StartsWithCapital_MinThreeCharacter_ShouldReturnTrue(string name)
        {
            try
            {
                string result = userDetailsPattern.ValidateLastName(name);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Valid Last Name", e.Message);
            }
        }

        ///// <summary>
        ///// Test Method to Invalidate Last name
        ///// </summary>
        [TestMethod]
        [DataRow("kHairnar")]
        [DataRow("pAtil")]
        [DataRow("aHER")]


        public void GivenLasttName_IfAll_LettersAreCapital_AndMinThreeCharacters_ShouldReturnFalse(string invalidLastName)
        {
            try
            {
                string result = userDetailsPattern.ValidateLastName(invalidLastName);
            }
            catch (UserException e)
            {
                Assert.AreEqual("Invalid Last Name", e.Message);
            }
        }
    }
}