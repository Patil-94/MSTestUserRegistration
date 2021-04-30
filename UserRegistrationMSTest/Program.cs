using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationMSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----Welcome To UserRegistrationMSTest-----");
            Console.WriteLine();


           
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine(UserDetail.validateFirstName(firstName));
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine(UserDetail.validateLastName(lastName));
            Console.WriteLine("Enter Email Address");
            string email = Console.ReadLine();
            Console.WriteLine(UserDetail.validateEmail(email));
            Console.WriteLine("Enter Mobile Number");
            string mobileNo = Console.ReadLine();
            Console.WriteLine(UserDetail.validateMobileNo(mobileNo));
            Console.WriteLine("Enter password");
            string password = Console.ReadLine();
            Console.WriteLine(UserDetail.validatePassword(password));

            Console.WriteLine("-------------------Email Sample Validator-----------------");
            Console.WriteLine();
            //list object cration with string data type
            List<string> emaillist = new List<string>();

            EmailSamples.emailValidator(emaillist);//method call
            Console.Read();
        }

    }
}
