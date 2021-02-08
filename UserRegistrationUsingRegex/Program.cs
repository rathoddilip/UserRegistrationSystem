
using System;
using System.Text.RegularExpressions;

namespace UserRegistrationUsingRegex
{
    public class UserRegex
    {
        Regex emailregex = new Regex("^[a-zA-Z0-9]+([._+-][a-zA-Z0-9]+)*@[a-zA-Z0-9]+.[a-zA-Z]{2,4}(.[][a-zA-Z]{2})*$");
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
            
            Console.WriteLine("Email: " + Email);

            if (emailregex.IsMatch(Email))
                Console.WriteLine("Valid EmailId");
            else
                Console.WriteLine("Invalid EmailId");
        }

        internal void MobileNumberRegex(string MobileNumber)
        {
            Regex MobileNumberregex = new Regex(@"^[0-9]{2,}\s[0-9]{10,}$");
            Console.WriteLine("Mobile Numbe: " + MobileNumber);

            if (MobileNumberregex.IsMatch(MobileNumber))
                Console.WriteLine("Valid Mobile Number");
            else
                Console.WriteLine("Invalid Mobile Number");
        }
        internal void PasswordRule1Regex(string PasswordRule1)
        {
            Regex PasswordRule1regex = new Regex(@"^.{8,}$");
            Console.WriteLine("Password: " + PasswordRule1);

            if (PasswordRule1regex.IsMatch(PasswordRule1))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
        internal void PasswordRule2Regex(string PasswordRule2)
        {
            Regex PasswordRule2regex = new Regex(@"^(?=.*[A-Z]).{8,}$");
            Console.WriteLine("PasswordRule2: " + PasswordRule2);

            if (PasswordRule2regex.IsMatch(PasswordRule2))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
        internal void PasswordRule3Regex(string PasswordRule3)
        {
            Regex PasswordRule3regex = new Regex(@"^(?=.*[A-Z])(?=.*\d).{8,}$");
            Console.WriteLine("PasswordRule3: " + PasswordRule3);

            if (PasswordRule3regex.IsMatch(PasswordRule3))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }
        internal void PasswordRule4Regex(string PasswordRule4)
        {
            Regex PasswordRule4regex = new Regex(@"^(?=.{8,}$)(?=[^A-Z]*[A-Z][^A-Z]*$)\w*\W\w*$");
            Console.WriteLine("PasswordRule4: " + PasswordRule4);

            if (PasswordRule4regex.IsMatch(PasswordRule4))
                Console.WriteLine("Valid Password");
            else
                Console.WriteLine("Invalid Password");
        }

    }
    class Program
    {
        
        static void Main(string[] args)
        {
            UserRegex userRegex = new UserRegex();
            string Firstname = "Dilip";//valid
            string LastName = "Rathod";//valid
            string Email = "abc.xyz@bl.co.in";//valid
            string MobileNumber="91 7756994045";//valid
            string PasswordRule1 = "Admin@12&3$&";//valid-Minimum 8 charachter
            string PasswordRule2 = "ad$$&didDdsfsn41";//valid-atleast 1 uppercase character-all rules passed
            string PasswordRule3 = "ad$$&did3Ddsfsn";//valid-atleast 1 numeric number 
            string PasswordRule4 = "aff&sdfA9";//valid-exactly 1 special character
            string[] emailList = {"abc@yahoo.com","abc-100@yahoo.com",  "abc.100@yahoo.com",
                                "abc111@abc.com",  "abc-100@abc.net",  "abc.100@abc.com.au",  "abc@1.com",
                                "abc@gmail.com.com",  "abc+100@gmail.com",
                                "abc",   "abc@.com.my",  "abc123@gmail.a",  "abc123@.com",
                                "abc123@.com.com",  ".abc@abc.com",  "abc()*@gmail.com",  "abc@%*.com",
                                "abc..2002@gmail.com",  "abc.@gmail.com",  "abc@abc@gmail.com",
                                "abc@gmail.com.1a",  "abc@gmail.com.aa.au"};
            userRegex.FirstNameRegex(Firstname);
            userRegex.LastNameRegex(LastName);
            userRegex.EmailRegex(Email);
            userRegex.MobileNumberRegex(MobileNumber);
            userRegex.PasswordRule1Regex(PasswordRule1);
            userRegex.PasswordRule2Regex(PasswordRule2);
            userRegex.PasswordRule3Regex(PasswordRule3);
            userRegex.PasswordRule4Regex(PasswordRule4);
            foreach(string sampleEmailList in emailList)
            {
                userRegex.EmailRegex(sampleEmailList);
            }

        }
    }
}
