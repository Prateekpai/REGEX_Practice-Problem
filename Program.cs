using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace REGEXDemo
{
    public class Pattern
    {
        public static string Regex_Pattern = "^.*(?=.{8,})(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z]).*$";
        public bool validatePincode(string Pincode)
        {
            return Regex.IsMatch(Pincode, Regex_Pattern);
        }
    }
    public class REGEX
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("The Password shall contain atleast 8 Character, atleast One Uppercase & Number");
            Console.WriteLine("Enter Password ");
            string Pincode = Console.ReadLine();

            Pattern pattern = new Pattern();
            Console.WriteLine("....................................");
            if (pattern.validatePincode(Pincode))
                Console.WriteLine("Your Password {0} is saved", Pincode);
            else
                Console.WriteLine("Enter Valid Password");
        }
    }
}
