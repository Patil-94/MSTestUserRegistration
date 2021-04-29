﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMSTest
{
    public class UserDetail
    {
        //Regular expression patterns for mobile number
        public static string passwordPattern = "^[A-Z]{1}[a-z]{7,}$";

        //Validation of  all the details
        public Func<string, string> ValidatePassword = x => Regex.IsMatch(x, passwordPattern) ? "Valid password" :
           throw new UserException(UserException.ExceptionType.INVALID_PASSWORD, "Invalid password");


    }
}

