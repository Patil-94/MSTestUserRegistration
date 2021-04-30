using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMSTest
{
    public class UserDetail
    { 
        //pattern for Name,Emailid,mobileno,password
        public static string Pattern = "^[A-Z]{1}[A-Za-z]{2,}$";
        public static string EmailID = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.,-]+$";
        public static string MobileNo = "^91\\s[1-9]{1}[0-9]{9}$";
        public static string Password = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";

        public  bool validateFirstName(string First_Name) //non static method and return value is bool
        {
            try
            {
                Regex regexObj = new Regex(Pattern);

                //call the IsMatch metod to determine whether a match is present and store in result variable
                 bool result = regexObj.IsMatch(First_Name); 
                  return result;
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name,Name should be first letter capital");
            }
        }

        public  bool validateLastName(string Last_Name)///non static method  to validate string and return value is bool
        {
            try
            { 
                Regex regexObj1 = new Regex(Pattern);
                bool result= regexObj1.IsMatch(Last_Name); //call the IsMatch metod to determine whether a match is present
                                                           //and store in result variable
                return result;
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name,Name should be first letter capital");
            }
        }

        public  bool validateEmail(string email)//create method
        {
            try
            {
             
                Regex regexObj2 = new Regex(EmailID);
                bool result=regexObj2.IsMatch(email);//call the IsMatch metod to determine whether a match is present
                                                     //and store in result variable
                return result;
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
        }

        public  bool validateMobileNo(string mobileNo)//create method
        {
            try
            {
               
                Regex regexObj3 = new Regex(MobileNo);
                bool result= regexObj3.IsMatch(mobileNo);//call the IsMatch metod to determine whether a match is present
                                                         //and store in result variable
                return result;
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Mobile number,number should be predefined format");
            }
        }

        public  bool validatePassword(string password)//creating method
        {
            try
            {
          
                Regex regexObj4 = new Regex(Password);
                bool result= regexObj4.IsMatch(password);//call the IsMatch metod to determine whether a match is present
                return result;
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password,Password should be in format");
            }
        }

       



        /// <summary>
        /// Using Lambda Expression
        /// </summary>
        public bool ValidateUserDetailFirstName (string  firstname)=> Regex.IsMatch(firstname, Pattern);
        public bool  ValidateUserDetailLAstNAme(string Last_Name) => Regex.IsMatch(Last_Name, Pattern);
        public  bool ValidateEMail(string email) => Regex.IsMatch(email, EmailID);
        public bool ValidateMobile(string mobileNo) => Regex.IsMatch(mobileNo, MobileNo);
        public bool ValidatePassword(string password) => Regex.IsMatch(password, Password);
    }
}



    
















