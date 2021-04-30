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

        public static bool validateFirstName(string name)
        {
            try
            {
                string expression = "^[A-Z]{1}[a-z]{2,}$";
                Regex regexObj = new Regex(expression);
                return regexObj.IsMatch(name);
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_FIRSTNAME, "Invalid First Name,Name should be first letter capital");
            }
        }

        public static bool validateLastName(string name)
        {
            try
            {
                string expression = "^[A-Z]{1}[a-z]{2,}$";
                Regex regexObj1 = new Regex(expression);
                return regexObj1.IsMatch(name);
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name,Name should be first letter capital");
            }
        }

        public static bool validateEmail(string email)
        {
            try
            {
                string expression = "^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.,-]+$";
                Regex regexObj2 = new Regex(expression);
                return regexObj2.IsMatch(email);
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAIL, "Invalid Email");
            }
        }

        public static bool validateMobileNo(string mobileNo)
        {
            try
            {
                string expression = "([+][9]{1}[1]{1}[ ])?[6-9]{1}[0-9]{9}";
                Regex regexObj3 = new Regex(expression);
                return regexObj3.IsMatch(mobileNo);
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Mobile number,number should be predefined format");
            }
        }

        public static bool validatePassword(string password)
        {
            try
            {
                string expression = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";
                Regex regexObj4 = new Regex(expression);
                return regexObj4.IsMatch(password);
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_PASSWORD, "Invalid Password,Password should be in format");
            }
        }

        public static bool validateEmailList(string email)
        {
            try
            {
                String emailPattern = "^([A-Za-z\\d-_\\+]+)(\\.[A-Za-z\\d-_]+)?@([a-zA-Z\\d]+)\\.([a-zA-Z]{2,4})(\\.[A-Za-z]{2,4})?$";
                Regex obj = new Regex(emailPattern);
                return obj.IsMatch(email);
            }
            catch (UserRegistrationException)
            {
                throw new UserRegistrationException(UserRegistrationException.ExceptionType.INVALID_EMAILLIST, "Invalid Email.Email should be in format");
            }
        }
    }
}














