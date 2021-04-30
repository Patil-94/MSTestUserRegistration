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
        readonly string name;
        public static bool validateFirstName(string name) //create method validate to string
        {
            string expression = "^[A-Z]{1}[A-Za-z]{2,}$";//create pattern for firstname 
            Regex regexObj = new Regex(expression);//object of regex
            return regexObj.IsMatch(name);  //call the IsMatch metod to determine whether a match is present
        }

        public static bool validateLastName(string name)//create method validate to string
        {
            string expression = "^[A-Z]{1}[a-z]{2,}$";//create pattern for lastname 
            Regex regexObj1 = new Regex(expression);//object of regex
            return regexObj1.IsMatch(name);  //call the IsMatch metod to determine whether a match is present
        }

        public static bool validateEmail(string email)//create method validate to string
        {
            string expression = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";//create pattern for emailid 
            Regex regexObj2 = new Regex(expression);//object of regex
            return regexObj2.IsMatch(email);  //call the IsMatch metod to determine whether a match is present
        }

        public static bool validateMobileNo(string mobileNo)//create method validate to string
        {
            string expression = "^91\\s[1-9]{1}[0-9]{9}$";//create pattern for mobile no
            Regex regexObj3 = new Regex(expression);//object of regex
            return regexObj3.IsMatch(mobileNo);  //call the IsMatch metod to determine whether a match is present
        }

        public static bool validatePassword(string password)//create method validate to string
        {
            string expression = "^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[#?!@$%^&*-]).{8,}$";//create pattern for password
            Regex regexObj4 = new Regex(expression);//object of regex
            return regexObj4.IsMatch(password);  //call the IsMatch metod to determine whether a match is present
        }
    }
}
        
            
        
    







    


