using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXDemo
{
    public class Pattern
    {
        public  string UserFirstName = "[A-Z]{1}[a-z]{2,}";
        public  string UserLastName = "[A-Z]{1}[a-z]{2,}";
        public  string UserMobileNumber = "[0-9]{2}(.)[0-9]{10}";
        public  string UserPassword = "^.*(?=.{8,})(?=.*[a-z])(?=.*[A-Z])(?=.*[!*@#$%^&+=]).*$";
        public  string UserEmail = "[a-z]{3}(.)[a-z]{3}(@)[a-z]{2}(.)[a-z]{2}(.)[a-z]{2}";
        public bool validateFirstName(string FirstName)
        {
            return Regex.IsMatch(FirstName, UserFirstName);
        }
        public bool validateLastName(string LastName)
        {
            return Regex.IsMatch(LastName, UserLastName);
        }
        public bool validateMobileNumber(string MobileNumber)
        {
            return Regex.IsMatch(MobileNumber, UserMobileNumber);
        }
        public bool validatePassword(string Password)
        {
            return Regex.IsMatch(Password, UserPassword);
        }
        public bool validateEmail(string EmailID)
        {
            return Regex.IsMatch(EmailID, UserEmail);
        }
    }
    public class REGEX
    {
        public static void Main(string[] args)
        {

                Console.WriteLine("Enter First Name ");
                string FirstName = Console.ReadLine();

                Console.WriteLine("Enter Last Name ");
                string LastName = Console.ReadLine();

                Console.WriteLine("Enter Mobile Number ");
                string MobileNumber = Console.ReadLine();

                Console.WriteLine("Enter E-Mail ");
                string EmailID = Console.ReadLine();

                Console.WriteLine("Enter Password ");
                string Password = Console.ReadLine();


                Pattern pattern = new Pattern();


                Console.WriteLine("....................................");
                {

                    if (pattern.validateFirstName(FirstName))
                        Console.WriteLine("First Name: {0} is Saved", FirstName);

                    else
                        Console.WriteLine("Enter Valid First Name");
                }
                {
                    if (pattern.validateLastName(LastName))
                        Console.WriteLine("Last Name: {0} is Saved", LastName);
                    else
                        Console.WriteLine("Enter Valid last Name");
                }

                {
                    if (pattern.validateMobileNumber(MobileNumber))
                        Console.WriteLine("Mobile Number: {0} is Saved", MobileNumber);
                    else
                        Console.WriteLine("Enter Valid Mobile Number");
                }

                {
                    if (pattern.validateEmail(EmailID))
                        Console.WriteLine("Email: {0} is Saved", EmailID);
                    else
                        Console.WriteLine("Enter Valid Email");
                }

                {
                    if (pattern.validatePassword(Password))
                        Console.WriteLine("Password: *********** is Saved");
                    else
                        Console.WriteLine("Enter Valid Password");
                }

            

        }
    }
}
