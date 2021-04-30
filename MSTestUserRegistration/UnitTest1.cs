using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationMSTest;

namespace MSTestUserRegistration
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Given Valid First Name should return true
        /// </summary>
        [TestMethod]
        public void GivenFirstNameShouldReturnHappy()
        {
            try
            {
                //Act
                bool output = UserDetail.validateFirstName("Ankita");
            }

            catch(UserRegistrationException  e)
            {
                //Assert
                Assert.AreEqual("Invalid First Name,Name should be first letter capital", e.Message);
            }
        }

        /// <summary>
        /// Given Valid Last Name should return true
        /// </summary>
        [TestMethod]
        public void GivenLastNameShouldReturnHappy()
        {
            try
            {
                bool output = UserDetail.validateLastName("Patil");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Last Name,Name should be first letter capital", e.Message);
            }
        }

        /// <summary>
        /// Given Valid Email should return true
        /// </summary>
        [TestMethod]
        public void GivenValidEmailIdShouldReturnHappy()
        {

            try
            {
                //Act
                bool output = UserDetail.validateEmail("abc@gmail.com");
            }
            catch (UserRegistrationException e)
            {
                // Assert
                Assert.AreEqual("Invalid Email", e.Message);
            }
        }


        /// <summary>
        /// Given Valid Mobile No should return true
        /// </summary>
        [TestMethod]
        public void GivenValidMobileShouldReturnHappy()
        {
            try
            {
                bool output = UserDetail.validateMobileNo("91 9146293697");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Mobile number,number should be predefined format", e.Message);
            }
        }

        /// <summary>
        /// Given Valid Password should return true
        /// </summary>
        [TestMethod]
        public void GivenValidPasswordShouldReturnHappy()
        {
            try
            {
                bool output = UserDetail.validatePassword("Anki@123");
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Password,Password should be in format", e.Message);
            }

        }

        /// <summary>
        /// Test case for all valid and invalid emails
        /// </summary>
        /// <param name="email></param>
        [DataTestMethod]
        [DataRow("abc@yahoo.com")]
        [DataRow("abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com")]
        [DataRow("abc111@abc.com")]
        [DataRow("abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au")]
        [DataRow("abc@1.com")]
        [DataRow("abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com")]
        public void GivenValidEmailListShouldReturnsTrue(string email)
        {
            try
            {
                var result = UserDetail.validateEmailList(email);
            }
            catch (UserRegistrationException e)
            {
                Assert.AreEqual("Invalid Email.Email should be in format", e.Message);
            }
        }
    }
}
