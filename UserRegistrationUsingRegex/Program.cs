
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
    }
    class Program
    {

        static void Main(string[] args)
        {
            UserRegex userRegex = new UserRegex();
            string Firstname = "Dilip";
            userRegex.FirstNameRegex(Firstname);
        }
    }
}
