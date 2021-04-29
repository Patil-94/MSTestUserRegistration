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
        //Regular expression patterns for mailID Pattern
        public static string mailIDPattern = "^([A-Za-z\\d-_\\+]+)(\\.[A-Za-z\\d-_]+)?@([a-zA-Z\\d]+)\\.([a-zA-Z]{2,4})(\\.[A-Za-z]{2,4})?$";
        //Validation of  all the details
        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, mailIDPattern) ? "Valid mailID" :
         throw new UserException(UserException.ExceptionType.INVALID_EMAIL_ID, "Invalid email id");

    }
}





    


