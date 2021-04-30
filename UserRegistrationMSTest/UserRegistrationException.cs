using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegistrationMSTest
{
    public class UserRegistrationException:Exception 
    {
        /// <summary>
        /// Enum of exception type.
        /// </summary>
        
        /// creating the variable of ExceptionType.
        ExceptionType type;
        public enum ExceptionType
        {
            INVALID_FIRSTNAME,
            INVALID_LASTNAME,
            INVALID_EMAIL,
            INVALID_MOBILE_NUMBER,
            INVALID_PASSWORD,
            INVALID_EMAILLIST
        }

        public UserRegistrationException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
