
using System;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    public class UserRegex
    {
       
        internal void FirstNameRegex(string Firstname)
        {
            Regex firstNameregex = new Regex("^[A-Z][a-zA-Z]{2,}$");
            Console.WriteLine("Firstname: " + Firstname);

            if (firstNameregex.IsMatch(Firstname))
                Console.WriteLine("Valid First name");
            else
                Console.WriteLine("Invalid first name");
        }
        internal void LastNameRegex(string LastName)
        {
            Regex LastNameregex = new Regex("^[A-Z][a-zA-Z]{2,}$");
            Console.WriteLine("Lastname: " + LastName);

            if (LastNameregex.IsMatch(LastName))
                Console.WriteLine("Valid last name");
            else
                Console.WriteLine("Invalid last name");
        }
        internal void EmailRegex(string Email)
        {
            Regex Emailregex = new Regex("^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}(.[][a-zA-Z]{2})*$");
            Console.WriteLine("Email: " + Email);

            if (Emailregex.IsMatch(Email))
                Console.WriteLine("Valid EmailId");
            else
                Console.WriteLine("Invalid EmailId");
        }

        internal void MobileNumberRegex(string MobileNumber)
        {
            Regex MobileNumberregex = new Regex(@"^[0-9]{2,}\s[0-9]{10,}$");
            Console.WriteLine("Mobile Numbe: " + MobileNumber);

            if (MobileNumberregex.IsMatch(MobileNumber))
                Console.WriteLine("Valid Mobile Numbe");
            else
                Console.WriteLine("Invalid Mobile Numbe");
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            UserRegex userRegex = new UserRegex();
            string Firstname = "Dilip";
            string LastName = "Rathod";
            string Email = "abc.xyz@bl.co.in";
            string MobileNumber="91 7756994045";
            userRegex.FirstNameRegex(Firstname);
            userRegex.LastNameRegex(LastName);
            userRegex.EmailRegex(Email);
            userRegex.MobileNumberRegex(MobileNumber);
        }
    }
}
