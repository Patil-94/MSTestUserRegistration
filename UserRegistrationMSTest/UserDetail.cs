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
        //Regular expression patterns for Last name
        public static string namePattern = "^[A-Z]{1}[A-Za-z]{2,}$";//1st letter Capital and Mini 3char

        //Validation of  all the details
        public Func<string, string> ValidateLastName = x => Regex.IsMatch(x, namePattern) ? "Valid Last Name" :
          throw new UserException(UserException.ExceptionType.INVALID_LASTNAME, "Invalid Last Name");


    }
}
