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
        //Regular expression patterns for EmailId
        public static string mailIDPattern = "^([a-z]{3,})([.]{0,1}[a-z]*)@([a-z]{2}).([a-z]{2})([.]{1}[a-z]{2}){0,1}$";

        //Validation of  all the details
        public Func<string, string> ValidateEmail = x => Regex.IsMatch(x, mailIDPattern) ? "Valid mailID" :
         throw new UserException(UserException.ExceptionType.INVALID_EMAIL_ID, "Invalid email id");

    }
}

