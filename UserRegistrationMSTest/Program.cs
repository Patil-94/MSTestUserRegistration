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

            UserDetail user = new UserDetail(); //creating object of Userdetail class

            Console.Write("Enter First Name : "); //input
            string First_Name = Console.ReadLine();//take input from user and store in first_Name variable
            Console.WriteLine(user.validateFirstName(First_Name)); //pass firstneme variable to the validatefirstname method 

            Console.Write("Enter Last Name : ");
            string Last_Name = Console.ReadLine();
            Console.WriteLine(user.validateLastName(Last_Name));

            Console.Write("Enter Email ID: ");
            string Email_Id = Console.ReadLine();
            Console.WriteLine(user.validateEmail(Email_Id));

            Console.Write("Enter Mobile Number: ");
            string Mobile_Number = Console.ReadLine();
            Console.WriteLine(user.validateMobileNo(Mobile_Number));

            Console.Write("Enter Paswrod: ");
            string Pwd = Console.ReadLine();
            Console.WriteLine(user.validatePassword(Pwd));

            Console.Read();

        }
    }
    
}
