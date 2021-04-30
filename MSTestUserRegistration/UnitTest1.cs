using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using UserRegistrationMSTest;

namespace MSTestUserRegistration
{
    [TestClass]
    public class Test
    {
        private readonly UserDetail User;
        public Test()//parameterless constructor 
        {
            User = new UserDetail(); //create object
        }
        /// <summary>
        /// Given Valid First Name should return true
        /// </summary>
        [TestMethod]
        public void validateFirstName()//method
        {
           var Result = User.validateFirstName("Ankita");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void validateLastName()
        {
            var Result = User.validateLastName("Patil");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void Email_Test()
        {
            var Result = User.validateEmail("ankita1995@gmail.com");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void Mobile_Test()
        {
            var Result = User.validateMobileNo("91 9865432666");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void Password_Test()
        {
            var Result = User.validatePassword("Prati@12");
            Assert.AreEqual(true, Result);

        }

        /// <summary>
        /// First the name using lambda expression.
        /// </summary>
        [TestMethod]
        public void FirstNameUsingLambdaExpression()
        {
            var Result = User.validateFirstName("Anki");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void LastNameUsingLambdaExpression()
        {
            var Result = User.validateLastName("Patil");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void EmailUsingLambdaExpression()
        {
            var Result = User.validateEmail("khairnar999@gmail.com");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void MobileNumberUsingLabdaExpression()
        {
            var Result = User.validateMobileNo("91 9975833272");
            Assert.AreEqual(true, Result);
        }

        [TestMethod]
        public void PasswordUingLambdaExpression()
        {
            var Result = User.validatePassword("Qwerty@123");
            Assert.AreEqual(true, Result);
        }
    }
}